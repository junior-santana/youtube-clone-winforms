using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace YouTubeClone.CustomControls
{ 
    public class CircularPictureBox : PictureBox
    {
        public CircularPictureBox()
        {
        }	

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			
			//Draw border to make it smoother
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			e.Graphics.DrawEllipse(new Pen(this.BackColor, 1), 0, 0, this.Width - 1, this.Height - 1);
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			//Create the circle and set the region property
			using (var gp = new GraphicsPath())
			{
				gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
				this.Region = new Region(gp);
			}
		}
	}
}
