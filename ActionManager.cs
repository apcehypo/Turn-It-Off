using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;

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
            if (MessageBox.Show(action.ToString(), Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            switch (action)
            {
                case Action.Logoff:
                    ExitWindowsEx(0, 0);
                    Application.Exit();
                    break;
                case Action.Sleep:
                    Application.SetSuspendState(PowerState.Suspend, true, false);
                    break;
                case Action.Shutdown:                    
                    Process.Start("shutdown", "/s /t 0");
                    Application.Exit();
                    break;
                case Action.Restart:
                    Process.Start("shutdown", "/r /t 0");
                    Application.Exit();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public static void DelayedDo(TimeSpan delay, Action action)
        {
            new DelayedAction<Action>(delay, ActionManager.Do, action);
        }

        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
    }
}
