using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurnItOff
{
    public partial class TrayForm
    {
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
        }
    }
}
