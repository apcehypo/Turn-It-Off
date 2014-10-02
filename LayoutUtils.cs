using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurnItOff
{
    public static class LayoutUtils
    {
        public static void PlaceFormNearNotifyIcon(Form form, Taskbar taskBar, Point mouseLocation)
        {
            int locX, locY;
            switch (taskBar.Position)
            {
                case TaskbarPosition.Right:
                    locY = mouseLocation.Y - form.Height / 2;
                    if (locY + form.Height >= taskBar.Size.Height - 8)
                        locY = taskBar.Size.Height - form.Height - 8;
                    form.Location = new Point
                    {
                        X = taskBar.Location.X - form.Width - 8,
                        Y = locY
                    };
                    break;
                case TaskbarPosition.Left:
                    locY = mouseLocation.Y - form.Height / 2;
                    if (locY + form.Height >= taskBar.Size.Height - 8)
                        locY = taskBar.Size.Height - form.Height - 8;
                    form.Location = new Point
                    {
                        X = taskBar.Location.X + taskBar.Size.Width + 8,
                        Y = locY
                    };
                    break;
                case TaskbarPosition.Bottom:
                    locX = mouseLocation.X - form.Width / 2;
                    if (locX + form.Width >= taskBar.Size.Width - 8)
                        locX = taskBar.Size.Width - form.Width - 8;
                    form.Location = new Point
                    {
                        X = locX,
                        Y = taskBar.Location.Y - form.Height - 8
                    };
                    break;
                case TaskbarPosition.Top:
                    locX = mouseLocation.X - form.Width / 2;
                    if (locX + form.Width >= taskBar.Size.Width - 8)
                        locX = taskBar.Size.Width - form.Width - 8;
                    form.Location = new Point
                    {
                        X = locX,
                        Y = taskBar.Location.Y + taskBar.Size.Height + 8
                    };
                    break;
            }
        }
    }
}
