using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TurnItOff
{
    public partial class TrayForm
    {
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                actionManager.Dispose();
                if (components != null)
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }
        
        protected override void WndProc(ref Message message)
        {
            const int WM_NCHITTEST = 0x0084;

            if (message.Msg == WM_NCHITTEST)
                return;

            base.WndProc(ref message);
        }

        RegistryKey rkAutoRun = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        RegistryKey rkApplication = Registry.CurrentUser.CreateSubKey(string.Format(@"SOFTWARE\{0}\{1}", Application.CompanyName, Application.ProductName));

        ActionManager actionManager = new ActionManager();

        public TrayForm()
        {
            InitializeComponent();
            this.Size = new Size(84, 252);
            tools.Renderer = new ClearStripRenderer();
            toolsDelay.Renderer = new ClearStripRenderer();
            toolsCancellation.Renderer = new ClearStripRenderer();

            menuAutorun.Checked = rkAutoRun.GetValue(Application.ProductName) != null;
            menuConfirmation.Checked = rkApplication.GetValue("Confirmation", "True").ToString() == bool.TrueString;
            textCustomDelay.Tag = rkApplication.GetValue("CustomDelay", 90).ToString();
            LocaleInit();
        }

        string NotifyBallonTitle;
        string AboutBalloonText;
        string ShortlyBeforeBalloonText;
        void LocaleInit()
        {
            AboutBalloonText = "kIT Vision © 2014\r\n\r\nContact us:\r\n  http://www.kitvision.ru\r\n  apcehypo@gmail.com";
            NotifyBallonTitle = Application.ProductName + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            ShortlyBeforeBalloonText = "\r\nLeft {0} minutes before the action {1}   \r\n ";
            notifyIcon.Text = "Shutdown, restart, log off and more";                            
        }
    }
}
