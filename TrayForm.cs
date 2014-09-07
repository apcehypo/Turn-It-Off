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
        private void TrayForm_Deactivate(object sender, EventArgs e)
        {
            Hide();
            panelDelay.Hide();
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

        private void toolButtons_MouseUp(object sender, MouseEventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button != null)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        ActionManager.Do((ActionManager.Action)Enum.Parse(typeof(ActionManager.Action), button.Tag as string));
                        break;
                    case MouseButtons.Right:
                        tools.Tag = button.Tag; //сохраняем выбранное действие
                        panelDelay.Dock = DockStyle.Fill;
                        panelDelay.Show();
                        break;
                }
            }
        }

        private void toolDelay_Click(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button != null)
            {
                if (button.Tag != null)
                {
                    ActionManager.DelayedDo(
                        new TimeSpan(0, 0, int.Parse(button.Tag as string)),
                        (ActionManager.Action)Enum.Parse(typeof(ActionManager.Action), tools.Tag as string)
                    );
                    this.Hide();
                    panelDelay.Hide();
                }
            }
        }
    }
}
