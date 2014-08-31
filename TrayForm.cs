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
        public TrayForm()
        {
            InitializeComponent();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            //Program.form.Width = 64;
            Program.form.Show();
        }
    }
}
