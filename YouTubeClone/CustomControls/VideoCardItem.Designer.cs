namespace YouTubeClone.CustomControls
{
	partial class VideoCardItem
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoCardItem));
			this.picVideoThumbnail = new System.Windows.Forms.PictureBox();
			this.pnlVideoDescription = new System.Windows.Forms.Panel();
			this.lblVideoInfo = new System.Windows.Forms.Label();
			this.lblChannelName = new System.Windows.Forms.Label();
			this.picChannelThumbnail = new YouTubeClone.CustomControls.CircularPictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picVideoThumbnail)).BeginInit();
			this.pnlVideoDescription.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picChannelThumbnail)).BeginInit();
			this.SuspendLayout();
			// 
			// picVideoThumbnail
			// 
			this.picVideoThumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picVideoThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picVideoThumbnail.Image = ((System.Drawing.Image)(resources.GetObject("picVideoThumbnail.Image")));
			this.picVideoThumbnail.ImageLocation = "";
			this.picVideoThumbnail.InitialImage = global::YouTubeClone.Properties.Resources.imgholdr_image;
			this.picVideoThumbnail.Location = new System.Drawing.Point(0, 0);
			this.picVideoThumbnail.Name = "picVideoThumbnail";
			this.picVideoThumbnail.Size = new System.Drawing.Size(253, 142);
			this.picVideoThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picVideoThumbnail.TabIndex = 4;
			this.picVideoThumbnail.TabStop = false;
			// 
			// pnlVideoDescription
			// 
			this.pnlVideoDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlVideoDescription.BackColor = System.Drawing.Color.Transparent;
			this.pnlVideoDescription.Controls.Add(this.lblVideoInfo);
			this.pnlVideoDescription.Controls.Add(this.lblChannelName);
			this.pnlVideoDescription.Controls.Add(this.picChannelThumbnail);
			this.pnlVideoDescription.Controls.Add(this.lblTitle);
			this.pnlVideoDescription.Location = new System.Drawing.Point(0, 142);
			this.pnlVideoDescription.Name = "pnlVideoDescription";
			this.pnlVideoDescription.Size = new System.Drawing.Size(253, 94);
			this.pnlVideoDescription.TabIndex = 3;
			// 
			// lblVideoInfo
			// 
			this.lblVideoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblVideoInfo.AutoEllipsis = true;
			this.lblVideoInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblVideoInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVideoInfo.ForeColor = System.Drawing.Color.DarkGray;
			this.lblVideoInfo.Location = new System.Drawing.Point(49, 77);
			this.lblVideoInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lblVideoInfo.Name = "lblVideoInfo";
			this.lblVideoInfo.Size = new System.Drawing.Size(188, 15);
			this.lblVideoInfo.TabIndex = 4;
			this.lblVideoInfo.Text = "0K views - 0 months ago";
			// 
			// lblChannelName
			// 
			this.lblChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblChannelName.AutoEllipsis = true;
			this.lblChannelName.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblChannelName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChannelName.ForeColor = System.Drawing.Color.DarkGray;
			this.lblChannelName.Location = new System.Drawing.Point(49, 59);
			this.lblChannelName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lblChannelName.Name = "lblChannelName";
			this.lblChannelName.Size = new System.Drawing.Size(188, 15);
			this.lblChannelName.TabIndex = 3;
			this.lblChannelName.Text = "Channel Name";
			// 
			// picChannelThumbnail
			// 
			this.picChannelThumbnail.BackColor = System.Drawing.Color.DimGray;
			this.picChannelThumbnail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picChannelThumbnail.BackgroundImage")));
			this.picChannelThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picChannelThumbnail.ImageLocation = "";
			this.picChannelThumbnail.InitialImage = null;
			this.picChannelThumbnail.Location = new System.Drawing.Point(3, 14);
			this.picChannelThumbnail.Name = "picChannelThumbnail";
			this.picChannelThumbnail.Size = new System.Drawing.Size(36, 36);
			this.picChannelThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picChannelThumbnail.TabIndex = 2;
			this.picChannelThumbnail.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.AutoEllipsis = true;
			this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblTitle.Location = new System.Drawing.Point(49, 14);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(157, 42);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Video Title";
			// 
			// VideoCardItem
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.picVideoThumbnail);
			this.Controls.Add(this.pnlVideoDescription);
			this.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
			this.Name = "VideoCardItem";
			this.Size = new System.Drawing.Size(253, 236);
			((System.ComponentModel.ISupportInitialize)(this.picVideoThumbnail)).EndInit();
			this.pnlVideoDescription.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picChannelThumbnail)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picVideoThumbnail;
		private System.Windows.Forms.Panel pnlVideoDescription;
		private System.Windows.Forms.Label lblChannelName;
		private CircularPictureBox picChannelThumbnail;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblVideoInfo;
	}
}
