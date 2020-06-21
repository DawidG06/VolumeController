using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeController
{
    class NotificationToast
    {

        private static NotificationToast _instance = new NotificationToast();
        public static NotificationToast getInstance()
        {
            if (_instance == null)
            {
                _instance = new NotificationToast();
            }

            return _instance;
        }

        private readonly NotifyIcon _notifyIcon;
        private NotificationToast()
        {
            _notifyIcon = new NotifyIcon();
            // Extracts your app's icon and uses it as notify icon
            _notifyIcon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            // Hides the icon when the notification is closed
            _notifyIcon.BalloonTipClosed += (s, e) => _notifyIcon.Visible = false;
        }


        public void Show(string title, string message, ToolTipIcon icon = ToolTipIcon.None, int timeout = 3000)
        {
            _notifyIcon.Visible = true;
            // Shows a notification with specified message and title
            _notifyIcon.ShowBalloonTip(timeout, title, message, icon);
            
        }


    }
}
