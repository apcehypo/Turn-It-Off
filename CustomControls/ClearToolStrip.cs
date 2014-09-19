using Digitalis.GUI.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurnItOff
{
    public class ClearToolStrip : ToolStrip
    {
        ToolStripItem mouseOverItem = null;
        Point mouseOverPoint;
        Timer timer;
        public InteractiveToolTip Tooltip;
        public int ToolTipInterval = 4000;
        public string ToolTipText;
        public InteractiveToolTip.StemPosition StemPosition = InteractiveToolTip.StemPosition.BottomRight;
        public Control Content;

        protected override void OnMouseMove(MouseEventArgs mea)
        {
            base.OnMouseMove(mea);
            ToolStripItem newMouseOverItem = this.GetItemAt(mea.Location);
            if (mouseOverItem != newMouseOverItem ||
                (Math.Abs(mouseOverPoint.X - mea.X) > SystemInformation.MouseHoverSize.Width || (Math.Abs(mouseOverPoint.Y - mea.Y) > SystemInformation.MouseHoverSize.Height)))
            {
                mouseOverItem = newMouseOverItem;
                mouseOverPoint = mea.Location;
                if (Tooltip != null)
                    Tooltip.Hide();
                timer.Stop();
                timer.Start();
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            ToolStripItem newMouseOverItem = this.GetItemAt(e.Location);
            if (newMouseOverItem != null && Tooltip != null)
            {
                Tooltip.Hide();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mea)
        {
            base.OnMouseUp(mea);
            ToolStripItem newMouseOverItem = this.GetItemAt(mea.Location);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            timer.Stop();
            if (Tooltip != null)
                Tooltip.Hide();
            mouseOverPoint = new Point(-50, -50);
            mouseOverItem = null;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            try
            {
                Point currentMouseOverPoint;
                currentMouseOverPoint = new Point(0, 0);

                if (mouseOverItem == null)
                {
                    if (ToolTipText != null && ToolTipText.Length > 0)
                    {
                        if (Tooltip == null)
                            Tooltip = new InteractiveToolTip();
                        Content = CreateDefaultContent(ToolTipText);
                        Tooltip.Show(Content, this, currentMouseOverPoint, StemPosition, ToolTipInterval);
                    }
                }
                else if ((!(mouseOverItem is ToolStripDropDownButton) && !(mouseOverItem is ToolStripSplitButton)) ||
                    ((mouseOverItem is ToolStripDropDownButton) && !((ToolStripDropDownButton)mouseOverItem).DropDown.Visible) ||
                    (((mouseOverItem is ToolStripSplitButton) && !((ToolStripSplitButton)mouseOverItem).DropDown.Visible)))
                {
                    if (mouseOverItem.ToolTipText != null && mouseOverItem.ToolTipText.Length > 0 && Tooltip != null)
                    {
                        if (Tooltip == null)
                            Tooltip = new InteractiveToolTip();
                        Content = CreateDefaultContent(mouseOverItem.ToolTipText);
                        Tooltip.Show(Content, this, currentMouseOverPoint, StemPosition, ToolTipInterval);
                    }
                }
            }
            catch
            { }
        }

        private Control CreateDefaultContent(string Text)
        {
            DefaultContentClass content = new DefaultContentClass();
            content.Text = Text;
            content.Size = TextRenderer.MeasureText(Text, content.Font);
            return content;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                timer.Dispose();
                Tooltip.Dispose();
            }
        }

        public ClearToolStrip()
            : base()
        {
            ShowItemToolTips = false;
            timer = new Timer();
            timer.Enabled = false;
            timer.Interval = SystemInformation.MouseHoverTime;
            timer.Tick += new EventHandler(timer_Tick);
            Tooltip = new InteractiveToolTip();

            Content = new DefaultContentClass();
            Renderer = new ClearStripRenderer();
        }
        private class DefaultContentClass : Label
        {
            public DefaultContentClass()
                : base()
            {
                this.BackColor = Color.Transparent;
                this.AutoSize = true;
            }
        }
    }

    public class ClearStripRenderer : ToolStripProfessionalRenderer
    {
        public ClearStripRenderer()
            : base()
        {

        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
        }

    }


}
