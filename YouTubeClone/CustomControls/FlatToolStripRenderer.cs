using System.Drawing;
using System.Windows.Forms;

namespace YouTubeClone.CustomControls
{
	internal class FlatToolStripRenderer : ToolStripRenderer
	{
		private SolidBrush highligthBgColor;
		private SolidBrush highligthBgColor2;

		public FlatToolStripRenderer()
		{
			highligthBgColor = new SolidBrush(Color.FromArgb(56, 56, 56));
			highligthBgColor2 = new SolidBrush(Color.FromArgb(90, 90, 90));
		}

		protected override void InitializeItem(ToolStripItem item)
		{
			base.InitializeItem(item);

			if (item is ToolStripButton)
			{
				item.MouseEnter += (object sender, System.EventArgs e) => { item.GetCurrentParent().Cursor = Cursors.Hand; };
				item.MouseLeave += (object sender, System.EventArgs e) => { item.GetCurrentParent().Cursor = Cursors.Default; };
			}
		}

		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			e.Graphics.DrawLine(new Pen(Color.FromArgb(64, 64, 64), 0.5f), 0, 0, e.Item.Width, 0);
		}

		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{

			var btnItem = e.Item as ToolStripButton;

			if (btnItem != null && (btnItem.Selected || btnItem.Checked))
			{

				if ((btnItem.Selected && btnItem.Checked) || btnItem.Pressed)
				{
					e.Graphics.FillRectangle(highligthBgColor2, 0, 0, e.Item.Width, e.Item.Height);
				}
				else
				{
					e.Graphics.FillRectangle(highligthBgColor, 0, 0, e.Item.Width, e.Item.Height);
				}

			}
			else
			{
				base.OnRenderButtonBackground(e);
			}

		}

		protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
		{
			if (e.Image != null && e.Item.TextImageRelation == TextImageRelation.ImageBeforeText)
			{
				var rect = new Rectangle(e.ImageRectangle.Left + 20, e.ImageRectangle.Top, e.ImageRectangle.Width, e.ImageRectangle.Height);

				//e.ImageRectangle is read-only so I have to override this
				e = new ToolStripItemImageRenderEventArgs(e.Graphics, e.Item, rect);
			}

			base.OnRenderItemImage(e);
		}

		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
		{
			if (e.Item.Image != null && e.Item.TextImageRelation == TextImageRelation.ImageBeforeText)
			{
				var rect = new Rectangle(e.TextRectangle.Left + 40, e.TextRectangle.Top , e.TextRectangle.Width, e.TextRectangle.Height);

				e.TextRectangle = rect;
			}

			base.OnRenderItemText(e);
		}
	}
}
