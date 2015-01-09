using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurnItOff.CustomControls;

namespace TurnItOff
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
                taskBar = new Taskbar();
                PrepareSizeAndLocation(Control.MousePosition);
                this.Show();
                this.Activate();
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(2000, NotifyBallonTitle, AboutBalloonText, ToolTipIcon.Info);
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
            //MessageForm.Create("hello", "world", taskBar, MousePosition).ShowDialog(); ;
            //return;
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
            ToolStripItem button = sender as ToolStripItem;
            if (button != null)
            {
                if (button.Tag != null)
                {
                    ActionManager.Action action = (ActionManager.Action)Enum.Parse(typeof(ActionManager.Action), tools.Tag as string);
                    var worker = actionManager.DelayedDo(
                        new TimeSpan(0, int.Parse(button.Tag as string), 0),
                        action
                    );
                    worker.Tick += (o, t) => { timeoutProgress.Text = t.TimeLeft.ToString(@"hh\:mm\:ss"); };
                    worker.ShortlyBeforeAction += (o, t) =>
                    {
                        notifyIcon.ShowBalloonTip(1000, NotifyBallonTitle, string.Format(ShortlyBeforeBalloonText, Math.Ceiling(t.TimeLeft.TotalMinutes), action), ToolTipIcon.Warning);
                    };
                    worker.RightBeforeAction += (o, c) =>
                    {
                        Invoke(new panelCancellationHideDelegate(() =>
                        {
                            Hide(); //сразу скроем форму, иначе будет мелькание
                            panelCancellation.Hide();
                        }));
                        c.Cancel = !ConfirmAction(action);
                    };
                    toolCancel.Click += (o, a) =>
                    {
                        worker.Cancel();
                        timeoutProgress.Text = "";
                        panelCancellation.Hide();
                    };
                    //SuspendLayout();
                    this.Hide();
                    panelDelay.Hide();
                    ShowCancellation(action);
                    //ResumeLayout();
                }
            }
        }

        private void menuConfirmation_CheckedChanged(object sender, EventArgs e)
        {
            rkApplication.SetValue("Confirmation", menuConfirmation.Checked);
        }

        private void textCustomDelay_Click(object sender, EventArgs e)
        {
            ToolStripTextBox tb = sender as ToolStripTextBox;
            if (tb.ReadOnly)
            {
                tb.ReadOnly = false;
                tb.Text = tb.Tag as string;
                tb.SelectAll();
            }
        }

        private void textCustomDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) { }
            else
            {
                e.KeyChar = (char)0;
            }
        }

        private void textCustomDelay_TextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox tb = sender as ToolStripTextBox;
            if (tb.Text == "") tb.Text = "0";
            tb.Tag = tb.Text;
        }

        private void textCustomDelay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                toolDelay_Click(sender, e);
                //запомним значение в реестре
                rkApplication.SetValue("CustomDelay", int.Parse(textCustomDelay.Text));
                //отмена обычного поведения
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TrayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (panelDelay.Visible)
                {
                    panelDelay.Hide();
                }
                else
                {
                    TrayForm_Deactivate(sender, e);
                }
            }
        }

    }
}
