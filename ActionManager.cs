using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TurnItOff
{
    public class ActionManager : IDisposable
    {
        public bool Confirmation { get; set; }

        public enum Action
        {
            Logoff,
            Sleep,
            Shutdown,
            Restart
        }

        public void Do(Action action)
        {
            switch (action)
            {
                case Action.Logoff:
                    NativeMethods.ExitWindowsEx(0, 0);
                    Application.Exit();
                    break;
                case Action.Sleep:
                    Application.SetSuspendState(PowerState.Suspend, true, false);
                    break;
                case Action.Shutdown:
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "shutdown",
                        Arguments = "/s /t 0",
                        WindowStyle = ProcessWindowStyle.Hidden
                    });
                    Application.Exit();
                    break;
                case Action.Restart:
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "shutdown",
                        Arguments = "/r /t 0",
                        WindowStyle = ProcessWindowStyle.Hidden
                    });
                    Application.Exit();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public DelayedAction<Action> _delayedAction;
        public DelayedAction<Action> DelayedDo(TimeSpan delay, Action action)
        {
            if (_delayedAction != null)
            {
                _delayedAction.Dispose();
            }
            _delayedAction = new DelayedAction<Action>(delay, Do, action);
            return _delayedAction;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_delayedAction != null) _delayedAction.Dispose();
            }
        }
    }
}
