using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayShutdownMenu
{
    public partial class TrayForm
    {
        private Orientation currentOrientation = Orientation.Vertical;
        private void SwitchFormOrientation(Orientation orientation)
        {
            if (orientation == currentOrientation) return;
            currentOrientation = orientation;
            Size newSize = new Size(this.Size.Height, this.Size.Width); //обмен
            this.SuspendLayout();
            this.Size = newSize;
            tools.LayoutStyle = tools.LayoutStyle == ToolStripLayoutStyle.HorizontalStackWithOverflow ? ToolStripLayoutStyle.VerticalStackWithOverflow : ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ResumeLayout();
        }

        private void PrepareSizeAndLocation(Point mouseLocation)
        {
            Taskbar taskBar = new Taskbar();
            //MessageBox.Show(string.Format("bounds: {0}  location: {1}  position: {2}  size: {3}  mouseLocation: {4}", taskBar.Bounds, taskBar.Location, taskBar.Position, taskBar.Size, mouseLocation));
            int locX, locY;
            switch (taskBar.Position)
            {
                case TaskbarPosition.Right:
                    SwitchFormOrientation(Orientation.Vertical);
                    locY = mouseLocation.Y - this.Height / 2;
                    if (locY + this.Height >= taskBar.Size.Height - 8)
                        locY = taskBar.Size.Height - this.Height - 8;
                    Location = new Point
                    {
                        X = taskBar.Location.X - this.Width - 8,
                        Y = locY
                    };
                    break;
                case TaskbarPosition.Left:
                    SwitchFormOrientation(Orientation.Vertical);
                    locY = mouseLocation.Y - this.Height / 2;
                    if (locY + this.Height >= taskBar.Size.Height - 8)
                        locY = taskBar.Size.Height - this.Height - 8;
                    Location = new Point
                    {
                        X = taskBar.Location.X + taskBar.Size.Width + 8,
                        Y = locY
                    };
                    break;
                case TaskbarPosition.Bottom:
                    SwitchFormOrientation(Orientation.Horizontal);
                    locX = mouseLocation.X - this.Width / 2;
                    if (locX + this.Width >= taskBar.Size.Width - 8)
                        locX = taskBar.Size.Width - this.Width - 8;
                    Location = new Point
                    {
                        X = locX,
                        Y = taskBar.Location.Y - this.Height - 8
                    };
                    break;
                case TaskbarPosition.Top:
                    SwitchFormOrientation(Orientation.Horizontal);
                    locX = mouseLocation.X - this.Width / 2;
                    if (locX + this.Width >= taskBar.Size.Width - 8)
                        locX = taskBar.Size.Width - this.Width - 8;
                    Location = new Point
                    {
                        X = locX,
                        Y = taskBar.Location.Y + taskBar.Size.Height + 8
                    };
                    break;
            }
        }

    }
}
