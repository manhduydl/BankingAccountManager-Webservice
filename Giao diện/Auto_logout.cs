using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityMonitor;
using System.Configuration;
using System.Windows.Forms;

namespace Giao_diện
{
    public class Auto_logout
    {
        
        public static ActivityMonitor.ActivityMonitor start_autolog()
        {
            ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();
            _am.WarningMinutes = float.Parse(ConfigurationSettings.AppSettings["WarningMinutes_value"]);
            _am.MaxMinutesIdle = float.Parse(ConfigurationSettings.AppSettings["MaxMinutesIdle_value"]);
            _am.Idle += new EventHandler(am_Idle);
            return _am;
          
        }

        static void am_Idle(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
