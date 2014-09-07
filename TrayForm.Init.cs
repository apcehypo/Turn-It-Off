using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayShutdownMenu
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

        public TrayForm()
        {
            InitializeComponent();
            this.Size = new Size(84, 252);
            tools.Renderer = new ClearStripRenderer();
            toolsDelay.Renderer = new ClearStripRenderer();            
            if (rkApp.GetValue(Application.ProductName) == null)
            {
                menuAutorun.Checked = false;
            }
            else
            {
                menuAutorun.Checked = true;
            }
        }

    }
}
