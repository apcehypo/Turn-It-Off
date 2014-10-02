using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurnItOff.CustomControls
{
    public partial class MessageForm : Form
    {
        public static MessageForm Create(string Question, string Action, Taskbar taskBar, Point mouseLocation)
        {
            MessageForm form = new MessageForm();
            LayoutUtils.PlaceFormNearNotifyIcon(form, taskBar, mouseLocation);
            return form;
        }

        private MessageForm()
        {
            InitializeComponent();

        }

        private void MessageForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Space:
                    {
                        toolOk.PerformClick();
                        break;
                    }
                case Keys.Escape:
                    {
                        toolCancel.PerformClick();
                        break;
                    }
            }
            e.SuppressKeyPress = true;
        }

        private void toolOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
