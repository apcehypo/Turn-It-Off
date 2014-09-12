using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurnItOff
{
    public partial class TrayForm : Form
    {
        private void TrayForm_Deactivate(object sender, EventArgs e)
        {
            Hide();
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

        private void menuAutorun_CheckedChanged(object sender, EventArgs e)
        {
            if (menuAutorun.Checked)
            {
                rkAutoRun.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
            }
            else
            {
                rkAutoRun.DeleteValue(Application.ProductName, false);
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
                        var action = (ActionManager.Action)Enum.Parse(typeof(ActionManager.Action), button.Tag as string);
                        if (ConfirmAction(action))
                        {
                            actionManager.Do(action);
                        }
                        break;
                    case MouseButtons.Right:
                        tools.Tag = button.Tag; //сохраняем выбранное действие
                        panelDelay.Dock = DockStyle.Fill;
                        panelDelay.Show();
                        break;
                }
            }
        }

        private bool ConfirmAction(ActionManager.Action action)
        {
            if (menuConfirmation.Checked)
            {
                return MessageBox.Show("Do you confirm a " + action.ToString() + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.Yes;
            }
            return true;
        }

        private delegate void panelCancellationHideDelegate();
        private void toolDelay_Click(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button != null)
            {
                if (button.Tag != null)
                {
                    ActionManager.Action action = (ActionManager.Action)Enum.Parse(typeof(ActionManager.Action), tools.Tag as string);
                    var worker = actionManager.DelayedDo(
                        new TimeSpan(0, int.Parse(button.Tag as string), 0),
                        action
                    );
                    worker.BeforeAction += (o, c) =>
                    {
                        Invoke(new panelCancellationHideDelegate(() =>
                        {
                            Hide(); //сразу скроем форму, иначе будет мелькание
                            panelCancellation.Hide();
                        }));
                        c.Cancel = !ConfirmAction(action);
                    };
                    worker.Tick += (o, t) => { timeoutProgress.Text = t.TimeLeft.ToString(@"hh\:mm\:ss"); };
                    //worker.DoTick();
                    toolCancel.Click += (o, a) =>
                    {
                        worker.Cancel();
                        timeoutProgress.Text = "";
                        panelCancellation.Hide();
                    };
                    //SuspendLayout();
                    panelDelay.Hide();
                    ShowCancellation(action);
                    //ResumeLayout();
                }
            }
        }

        private void menuConfirmation_CheckedChanged(object sender, EventArgs e)
        {
            if (menuConfirmation.Checked)
            {
                rkApplication.SetValue("Confirmation", true);
            }
            else
            {
                rkApplication.SetValue("Confirmation", false);
            }
        }

    }
}
