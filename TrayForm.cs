using Microsoft.Win32;
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
            this.Size = new Size(84, 252);
            toolStrip.Renderer = new ClearStripRenderer();
            if (rkApp.GetValue(Application.ProductName) == null)
            {
                menuAutorun.Checked = false;
            }
            else
            {
                menuAutorun.Checked = true;
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {

        }

        private void TrayForm_Deactivate(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            ActionManager.Do((ActionManager.Action)Enum.Parse(typeof(ActionManager.Action), (sender as ToolStripButton).Tag as string));
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
                //==>здесь надо бы проверить, не открыто ли уже окошко, и закрыть
                PrepareSizeAndLocation(Control.MousePosition);
                this.Show();
                this.Activate();
            }
        }

        private Orientation currentOrientation = Orientation.Vertical;
        private void SwitchFormOrientation(Orientation orientation)
        {
            if (orientation == currentOrientation) return;
            currentOrientation = orientation;
            Size newSize = new Size(this.Size.Height, this.Size.Width); //обмен
            this.SuspendLayout();
            this.Size = newSize;
            toolStrip.LayoutStyle = toolStrip.LayoutStyle == ToolStripLayoutStyle.HorizontalStackWithOverflow ? ToolStripLayoutStyle.VerticalStackWithOverflow : ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ResumeLayout();
        }

        private void PrepareSizeAndLocation(Point mouseLocation)
        {
            Taskbar taskBar = new Taskbar();
            //MessageBox.Show(string.Format("bounds: {0}  location: {1}  position: {2}  size: {3}  mouseLocation: {4}", taskBar.Bounds, taskBar.Location, taskBar.Position, taskBar.Size, mouseLocation));
            int locX, locY;
            switch (taskBar.Position)
            {
                case TaskbarPosition.Right:
                    SwitchFormOrientation(Orientation.Vertical);
                    locY = mouseLocation.Y - this.Height / 2;
                    if (locY + this.Height >= taskBar.Size.Height - 8)
                        locY = taskBar.Size.Height - this.Height - 8;
                    Location = new Point
                    {
                        X = taskBar.Location.X - this.Width - 8,
                        Y = locY
                    };
                    break;
                case TaskbarPosition.Left:
                    SwitchFormOrientation(Orientation.Vertical);
                    locY = mouseLocation.Y - this.Height / 2;
                    if (locY + this.Height >= taskBar.Size.Height - 8)
                        locY = taskBar.Size.Height - this.Height - 8;
                    Location = new Point
                    {
                        X = taskBar.Location.X + taskBar.Size.Width + 8,
                        Y = locY
                    };
                    break;
                case TaskbarPosition.Bottom:
                    SwitchFormOrientation(Orientation.Horizontal);
                    locX = mouseLocation.X - this.Width / 2;
                    if (locX + this.Width >= taskBar.Size.Width - 8)
                        locX = taskBar.Size.Width - this.Width - 8;
                    Location = new Point
                    {
                        X = locX,
                        Y = taskBar.Location.Y - this.Height - 8
                    };
                    break;
                case TaskbarPosition.Top:
                    SwitchFormOrientation(Orientation.Horizontal);
                    locX = mouseLocation.X - this.Width / 2;
                    if (locX + this.Width >= taskBar.Size.Width - 8)
                        locX = taskBar.Size.Width - this.Width - 8;
                    Location = new Point
                    {
                        X = locX,
                        Y = taskBar.Location.Y + taskBar.Size.Height + 8
                    };
                    break;
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(1000);
        }

        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        private void menuAutorun_CheckedChanged(object sender, EventArgs e)
        {
            if (menuAutorun.Checked)
            {
                rkApp.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
            }
            else
            {
                rkApp.DeleteValue(Application.ProductName, false);
            }
        }
    }
}
