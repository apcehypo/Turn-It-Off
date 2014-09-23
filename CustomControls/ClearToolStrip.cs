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
        public ClearToolStrip()
            : base()
        {
            ShowItemToolTips = true;            
            Renderer = new ClearStripRenderer();
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
