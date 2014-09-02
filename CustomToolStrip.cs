using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrayShutdownMenu
{
    //class CustomToolStrip : ToolStrip
    //{
    //    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    //    {
    //    }
    //}

    public class ClearStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
        }
    }
}
