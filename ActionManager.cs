using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayShutdownMenu
{
    static class ActionManager
    {
        public enum Action
        {
            Logoff,
            Sleep,
            Shutdown,
            Restart
        }

        public static void Do(Action action)
        {
            MessageBox.Show(action.ToString());

        }

    }
}
