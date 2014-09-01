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

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            ActionManager.Do(ActionManager.Action.Sleep);
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            ActionManager.Do(ActionManager.Action.Shutdown);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
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
                PrepareSizeAndLocation(Control.MousePosition);
                this.Show();
                this.Activate();
            }
        }

        private void PrepareSizeAndLocation(Point mouseLocation)
        {
            Taskbar taskBar = new Taskbar();
            //MessageBox.Show(string.Format("bounds: {0}  location: {1}  position: {2}  size: {3}  mouseLocation: {4}", taskBar.Bounds, taskBar.Location, taskBar.Position, taskBar.Size, mouseLocation));

            switch (taskBar.Position)
            {
                case TaskbarPosition.Right:
                    int Y = mouseLocation.Y - this.Height / 2;
                    if (Y + this.Height >= taskBar.Size.Height - 8)
                        Y = taskBar.Size.Height - this.Height - 8;
                    Location = new Point
                    {
                        X = taskBar.Location.X - this.Width - 8,
                        Y = Y
                    };

                    break;

            }
        }
    }
}
