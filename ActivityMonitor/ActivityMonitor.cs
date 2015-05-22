using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace ActivityMonitor
{
    public class ActivityMonitor : IDisposable, INotifyPropertyChanged
    {
        #region interop stuff
        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn,
        IntPtr hInstance, int threadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto,
         CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode,
        IntPtr wParam, IntPtr lParam);

        public enum HookType : int
        {
            WH_JOURNALRECORD = 0,
            WH_JOURNALPLAYBACK = 1,
            WH_KEYBOARD = 2,
            WH_GETMESSAGE = 3,
            WH_CALLWNDPROC = 4,
            WH_CBT = 5,
            WH_SYSMSGFILTER = 6,
            WH_MOUSE = 7,
            WH_HARDWARE = 8,
            WH_DEBUG = 9,
            WH_SHELL = 10,
            WH_FOREGROUNDIDLE = 11,
            WH_CALLWNDPROCRET = 12,
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        private const int WM_KEYDOWN = 0x0100;
        private HookProc _keyboardProc;
        private int _keyboardHookID = 0;
        private HookProc _mouseProc;
        private int _mouseHookID = 0;
        #endregion

        private Timer _timer = new Timer();

        public enum ActivityState
        {
            Active, Warned, Idle
        }

        public ActivityMonitor()
        {
            _keyboardProc = new HookProc(KeyboardHookCallback);
            _mouseProc = new HookProc(MouseHookCallback);
            _keyboardHookID = SetKeyboardHook(_keyboardProc);
            _mouseHookID = SetMouseHook(_mouseProc);

            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private frmAutoLogout _warningScreen;

        private ActivityState _currState = ActivityState.Active;

        public ActivityState CurrState
        {
            get { return _currState; }
        }

        private double _warningMinutes = 15; //default

        //number of minutes for the warning message to be shown
        public double WarningMinutes
        {
            get { return _warningMinutes; }
            set
            {
                bool changed = (_warningMinutes != value);
                _warningMinutes = value;
                if (changed)
                    OnPropertyChanged(ActivityMonitorProperties.WarningMinutes);
            }
        }

        private double _maxMinutesIdle = 30; //default

        public double MaxMinutesIdle
        {
            get { return _maxMinutesIdle; }
            set
            {
                bool changed = (_maxMinutesIdle != value);
                _maxMinutesIdle = value;
                if (changed)
                    OnPropertyChanged(ActivityMonitorProperties.MaxMinutesIdle);
            }
        }

        private DateTime _lastActivity = DateTime.Now;

        public DateTime LastActivity
        {
            get { return _lastActivity; }
            set
            {
                bool changed = (_lastActivity != value);
                _lastActivity = value;
                if (changed)
                    OnPropertyChanged(ActivityMonitorProperties.LastActivity);
            }
        }

        public event EventHandler Idle;

        private void UpdateState()
        {
            double timeElapsed = (DateTime.Now - _lastActivity).TotalMinutes;
            double timeLeft = _maxMinutesIdle - timeElapsed;

            if (timeLeft <= 0)
            {
                _currState = ActivityState.Idle;
                OnIdle();

                if (_warningScreen != null)
                    _warningScreen.Close(); //don't need to see this anymore
            }
            else if (timeLeft <= _warningMinutes)
            {
                _currState = ActivityState.Warned;
                if (_warningScreen == null)
                {
                    _warningScreen = new frmAutoLogout();
                    _warningScreen.MaxMinutesIdle = _maxMinutesIdle;
                    _warningScreen.Show();
                }

                _warningScreen.MinutesRemaining = timeLeft;
            }
            else
            {
                _currState = ActivityState.Active;

                if (_warningScreen != null)
                {
                    _warningScreen.Close(); //don't need to see this anymore
                    _warningScreen = null;
                }
            }
        }
        private void OnIdle()
        {
            if (Idle != null)
                Idle(this, EventArgs.Empty);
        }

        #region mouse stuff
        private int SetMouseHook(HookProc proc)
        {
            //int threadId = Thread.CurrentThread.ManagedThreadId;
            int threadId = AppDomain.GetCurrentThreadId();
            return SetWindowsHookEx((int)HookType.WH_MOUSE, proc, IntPtr.Zero, threadId);
        }

        private int MouseHookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            MouseMessages mouseInfo = (MouseMessages)wParam;

            if (nCode >= 0 &&
                ((mouseInfo == MouseMessages.WM_LBUTTONDOWN) || (mouseInfo == MouseMessages.WM_RBUTTONDOWN)))
            {
                _lastActivity = DateTime.Now;

                Debug.WriteLine("MouseHookCallback: " + _currState.ToString() + "\t" + DateTime.Now.ToString() + "\t" + nCode.ToString() + "\t" + wParam + "\t" + lParam);
                //Debug.WriteLine("\t" + hookStruct.flags.ToString() + "\t" + hookStruct.mouseData.ToString() + "\t" + hookStruct.time.ToString());
            }
            return CallNextHookEx(_mouseHookID, nCode, wParam, lParam);
        }
        #endregion

        #region keyboard stuff
        private int SetKeyboardHook(HookProc proc)
        {
            //int threadId = Thread.CurrentThread.ManagedThreadId;
            int threadId = AppDomain.GetCurrentThreadId();
            return SetWindowsHookEx((int)HookType.WH_KEYBOARD, proc,
                IntPtr.Zero, threadId);
        }

        private int KeyboardHookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                _lastActivity = DateTime.Now;
                //Debug.WriteLine("KeyboardHookCallback: " + DateTime.Now.ToString());
            }
            return CallNextHookEx(_keyboardHookID, nCode, wParam, lParam);
        }
        #endregion

        void _timer_Tick(object sender, EventArgs e)
        {
            UpdateState();
        }

        public void Dispose()
        {
            Debug.WriteLine("Dispose() start: " + DateTime.Now.ToString());
            UnhookWindowsHookEx(_keyboardHookID);
            UnhookWindowsHookEx(_mouseHookID);
            Debug.WriteLine("Dispose() end: " + DateTime.Now.ToString());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(ActivityMonitorProperties property)
        {
            if ((PropertyChanged != null))
                PropertyChanged(this, new PropertyChangedEventArgs(property.ToString()));
        }

        private enum ActivityMonitorProperties
        {
            ActivityState, WarningMinutes, MaxMinutesIdle, LastActivity
        }
    }

    public static class Utils
    {
        public static string TimespanToString(TimeSpan ts)
        {
            string result = "";
            if (ts.Hours >= 1)
                result += ts.Hours + " hr, ";
            if (ts.Minutes >= 1)
                result += ts.Minutes + " min, ";

            //if there's more than one min and the number of seconds is zero, don't show seconds
            if (!((ts.TotalSeconds >= 60) && (ts.Seconds == 0)))
                result += ts.Seconds + " sec";

            //remove commas, spaces from the end (if necessary)
            result = result.Trim(new char[] { ' ', ',' });

            return result;
        }
    }

}
