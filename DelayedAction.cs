using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TurnItOff
{
    public class DelayedAction<T> : IDisposable
    {
        public DelayedAction(TimeSpan delay, Action<T> action, T value)
        {
            _action = action;
            _timer = new Timer(1000);
            _timer.AutoReset = true;
            _timer.Elapsed += new ElapsedEventHandler((o, e) =>
            {
                if (DateTime.Now >= _finishTime) //пришло время срабатывания
                {
                    _timer.Dispose();
                    if (DoBeforeAction()) return; //отмена действия
                    action(value);
                }
                else //обычный тик
                {
                    DoTick();
                }
            });
            _timer.Start();
            _startTime = DateTime.Now;
            _finishTime = _startTime.AddMilliseconds(delay.TotalMilliseconds).AddSeconds(1);
        }

        public void Cancel()
        {
            _timer.Dispose();
        }

        public event EventHandler<CancelableEventArgs> BeforeAction;
        protected virtual void OnBeforeAction(CancelableEventArgs e)
        {
            EventHandler<CancelableEventArgs> handler = BeforeAction;
            if (handler != null)
            {
                handler(this, e);
                if (e.Cancel) Cancel();
            }
        }

        public event EventHandler<TickEventArgs> Tick;
        protected virtual void OnTick(TickEventArgs e)
        {
            EventHandler<TickEventArgs> handler = Tick;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private Action<T> _action;
        private Timer _timer;
        private DateTime _startTime;
        private DateTime _finishTime;


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

        internal bool DoBeforeAction()
        {
            var cancelator = new CancelableEventArgs { Cancel = false };
            OnBeforeAction(cancelator);
            return cancelator.Cancel;
        }
        internal void DoTick()
        {
            var now = DateTime.Now;
            OnTick(new TickEventArgs
            {
                TimeElapsed = now - _startTime,
                TimeLeft = _finishTime/*.AddSeconds(1)*/ - now
            });
        }
    }
    public class TickEventArgs : EventArgs
    {
        public TimeSpan TimeElapsed { get; set; }
        public TimeSpan TimeLeft { get; set; }
    }

    public class CancelableEventArgs : EventArgs
    {
        public bool Cancel { get; set; }
    }
}
