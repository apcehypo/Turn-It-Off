using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurnItOff
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
            tools.LayoutStyle = tools.LayoutStyle == ToolStripLayoutStyle.HorizontalStackWithOverflow ?
                ToolStripLayoutStyle.VerticalStackWithOverflow : ToolStripLayoutStyle.HorizontalStackWithOverflow;

            toolsCancellation.LayoutStyle = toolsCancellation.LayoutStyle == ToolStripLayoutStyle.HorizontalStackWithOverflow ?
                ToolStripLayoutStyle.VerticalStackWithOverflow : ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolCancel.Size = new Size(toolCancel.Size.Height, toolCancel.Size.Width); //обмен
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

        private void ShowCancellation(ActionManager.Action action)
        {
            panelCancellation.Dock = DockStyle.Fill;
            switch (action)
            {
                case ActionManager.Action.Logoff:
                    toolCancelLogoff.Visible = true;
                    toolCancelSleep.Visible = false;
                    toolCancelShutdown.Visible = false;
                    toolCancelRestart.Visible = false;
                    toolsCancellation.Items.Insert(0, toolCancelLogoff);
                    toolsCancellation.Items.Insert(1, toolCancel);
                    toolsCancellation.Items.Insert(2, timeoutProgress);
                    break;
                case ActionManager.Action.Sleep:
                    toolCancelLogoff.Visible = false;
                    toolCancelSleep.Visible = true;
                    toolCancelShutdown.Visible = false;
                    toolCancelRestart.Visible = false;
                    toolsCancellation.Items.Insert(0, timeoutProgress);
                    toolsCancellation.Items.Insert(1, toolCancelSleep);
                    toolsCancellation.Items.Insert(2, toolCancel);
                    break;
                case ActionManager.Action.Shutdown:
                    toolCancelLogoff.Visible = false;
                    toolCancelSleep.Visible = false;
                    toolCancelShutdown.Visible = true;
                    toolCancelRestart.Visible = false;
                    toolsCancellation.Items.Insert(0, toolCancel);
                    toolsCancellation.Items.Insert(1, toolCancelShutdown);
                    toolsCancellation.Items.Insert(2, timeoutProgress);
                    break;
                case ActionManager.Action.Restart:
                    toolCancelLogoff.Visible = false;
                    toolCancelSleep.Visible = false;
                    toolCancelShutdown.Visible = false;
                    toolCancelRestart.Visible = true;
                    toolsCancellation.Items.Insert(0, timeoutProgress);
                    toolsCancellation.Items.Insert(1, toolCancel);
                    toolsCancellation.Items.Insert(2, toolCancelRestart);
                    break;
            }

            panelCancellation.Show();

        }

    }
}
