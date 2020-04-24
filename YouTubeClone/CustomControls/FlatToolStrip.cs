using System;
using System.Windows.Forms;

namespace YouTubeClone.CustomControls
{
	class FlatToolStrip : ToolStrip
	{
		public FlatToolStrip()
		{
			this.Renderer = new FlatToolStripRenderer();
		}
	}
}
