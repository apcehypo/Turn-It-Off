using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TrayShutdownMenu
{
    class DelayedAction<T> : IDisposable 
    {
        public DelayedAction(TimeSpan delay, Action<T> action, T value)
        {
            _action = action;
            _timer = new Timer(delay.TotalMilliseconds);
            _timer.AutoReset = false;
            _timer.Elapsed += new ElapsedEventHandler((o, e) =>
            {
                action(value);
                _timer.Dispose();
            });
            _timer.Start();
        }

        private Action<T> _action;
        private Timer _timer;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_timer != null) _timer.Dispose();
            }
        }
    }
}
