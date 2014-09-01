using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayShutdownMenu
{
    public partial class TrayForm : Form
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Win32.DwmIsCompositionEnabled())
            {
                e.Graphics.Clear(Color.Black);
            }
        }

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
            Taskbar taskBar = new Taskbar();
            this.Location = new Point(1800, 600);
            this.BackColor = Color.Black;
            if (Win32.DwmIsCompositionEnabled())
            {
                Win32.MARGINS margins = new Win32.MARGINS { Top = -1, Left = -1, Bottom = -1, Right = -1 };
                Win32.DwmExtendFrameIntoClientArea(this.Handle, ref margins);
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {

        }

        private void TrayForm_Deactivate(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonLogoff_Click(object sender, EventArgs e)
        {
            ActionManager.Do(ActionManager.Action.Logoff);
        }

        private void buttonSuspend_Click(object sender, EventArgs e)
        {
            ActionManager.Do(ActionManager.Action.Sleep);
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            ActionManager.Do(ActionManager.Action.Shutdown);
        }

        private void buttonReboot_Click(object sender, EventArgs e)
        {
            ActionManager.Do(ActionManager.Action.Restart);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.form.Show();
                Program.form.Activate();
            }

        }

    }
}
