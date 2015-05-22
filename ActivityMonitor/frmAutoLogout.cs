using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActivityMonitor
{
    public partial class frmAutoLogout : Form
    {
        private double _minutesRemaining;
        public double MinutesRemaining
        {
            get { return _minutesRemaining; }
            set
            {
                _minutesRemaining = value;
                RefreshMinutesRemaining();
            }
        }
        private double _maxMinutesIdle;
        public double MaxMinutesIdle
        {
            get { return _maxMinutesIdle; }
            set
            {
                _maxMinutesIdle = value;
                RefreshMaxMinutesIdle();
            }
        }

        private void RefreshMinutesRemaining()
        {
            if (TimeSpan.FromMinutes(_minutesRemaining).TotalSeconds >= 1.0)
                lblCountdown.Text = "You have " + Utils.TimespanToString(TimeSpan.FromMinutes(_minutesRemaining)) + " remaining.";
            else
                lblCountdown.Text = "Closing...";
            lblCountdown.Refresh();
        }
        private void RefreshMaxMinutesIdle()
        {
            lblWarning.Text = "You have been inactive for too long.  "
                + "You will be logged-out of the application if you have been idle for more "
                + "than " + Utils.TimespanToString(TimeSpan.FromMinutes(_maxMinutesIdle)) + ".  Any unsaved work will be lost.";
            lblWarning.Refresh();
        }

        public frmAutoLogout()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}