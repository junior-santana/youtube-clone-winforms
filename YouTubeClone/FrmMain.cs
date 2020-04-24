using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouTubeClone.CustomControls;

namespace YouTubeClone
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private async void FrmMain_Load(object sender, EventArgs e)
		{
			mnuMain.Renderer = new FlatToolStripRenderer();
			mnuSubscriptions.Renderer = new FlatToolStripRenderer();
			mnuMoreOptions.Renderer = new FlatToolStripRenderer();

			//async calls
			await LoadVideoList();
		}

		private void CreateCardPlaceHolders()
		{
			var items = new List<Control>();

			for (int i = 1; i <= 12; i++)
			{
				items.Add(new VideoCardItem());
			}

			pnlVideos.Controls.Clear();
			pnlVideos.Controls.AddRange(items.ToArray());
		}

		private async Task LoadVideoList()
		{
			CreateCardPlaceHolders();

			List<Models.VideoDetails> recommendedVideos = await GetRecommendedList();

			int placeholdersCount = pnlVideos.Controls.Count;

			for (int i = 0; i < recommendedVideos.Count; i++)
			{
				Models.VideoDetails videoDetails = recommendedVideos[i];

				VideoCardItem item;

				if (placeholdersCount > 0)
				{
					item = (VideoCardItem)pnlVideos.Controls[i];
					placeholdersCount--;
				}
				else
				{
					item = new VideoCardItem();
					pnlVideos.Controls.Add(item);
				}

				item.ChannelName = videoDetails.ChannelName;
				item.ChannelThumbnail = videoDetails.ChannelThumbnail;
				item.Title = videoDetails.Title;
				item.Thumbnail = videoDetails.Thumbnail;
				item.Views = videoDetails.Views;
				item.PublishedDate = videoDetails.PublishedDate;

				item.Refresh();
			}

			while (placeholdersCount > 0)
			{
				pnlVideos.Controls.RemoveAt(pnlVideos.Controls.Count - 1);
				placeholdersCount--;
			}
		}

		private async Task<List<Models.VideoDetails>> GetRecommendedList()
		{
			//Emulating an API call
			await Task.Delay(1000);

			var recommendedVideos = new List<Models.VideoDetails>();
			var rnd = new Random();

			for (int repeat = 1; repeat <= 2; repeat++)
			{
				for (int i = 1; i <= 10; i++)
				{
					var video = new Models.VideoDetails
					{
						ChannelName = $"Creative Channel {i} Name",
						ChannelThumbnail = $@"..\..\..\img\avatars\{i}.jpg",
						Title = $"Absolutely Amazing Title of Video {i}",
						Thumbnail = $@"..\..\..\img\thumbnails\{i}.jpg",
						Views = (ulong)rnd.Next(100, 2000000),
						PublishedDate = DateTime.Now.AddDays(-rnd.Next(1000)).AddMinutes(-rnd.Next(60))
					};

					recommendedVideos.Add(video);
				}
			}

			return recommendedVideos;
		}

		private void txtSearch_Enter(object sender, EventArgs e)
		{
			txtSearch.Text = string.Empty;
		}

		private void txtSearch_Leave(object sender, EventArgs e)
		{
			txtSearch.Text = " Search";
		}

		private void pnlVideos_Scroll(object sender, ScrollEventArgs e)
		{
			pnlVideos.Refresh();
		}

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			await LoadVideoList();
		}

		private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.Name == "btnMainShowHide")
			{
				bool show = e.ClickedItem.Text.ToLower().Contains("more");

				foreach (ToolStripButton mnu in mnuMain.Items.OfType<ToolStripButton>())
				{
					if (mnu.Tag != null && mnu.Tag.ToString() == "collapsed")
					{
						mnu.Visible = show;
					}
				}

				if (show)
				{
					e.ClickedItem.Text = e.ClickedItem.Text.Replace("more", "less");
					e.ClickedItem.Image = Properties.Resources.arrow_up;
				}
				else
				{
					e.ClickedItem.Text = e.ClickedItem.Text.Replace("less", "more");
					e.ClickedItem.Image = Properties.Resources.arrow_down;
				}

			}
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			//not the cleanest solution here, but this menu's layout is very specific when it's collapsed

			var mainButtons = new List<ToolStripButton> { btnHome, btnTrending, btnSubscriptions, btnLibrary };

			pnlLeft.SuspendLayout();

			if (btnMenu.Tag.ToString() == "open")
			{
				foreach (ToolStripButton btn in mainButtons)
				{
					btn.TextImageRelation = TextImageRelation.ImageAboveText;
					btn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
					btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
					btn.Font = new System.Drawing.Font(btn.Font.FontFamily, 7);
					btn.Width = 72;
					btn.Height = 72;
				}

				pnlLeft.Width = 72;

				foreach (ToolStripItem item in mnuMain.Items)
				{
					if (!mainButtons.Contains(item))
					{
						item.Visible = false;
					}
				}

				mnuSubscriptions.Visible = false;
				mnuMoreOptions.Visible = false;
				btnMenu.Tag = "closed";
			}
			else
			{
				foreach (ToolStripButton btn in mainButtons)
				{
					btn.TextImageRelation = TextImageRelation.ImageBeforeText;
					btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
					btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
					btn.Font = new System.Drawing.Font(btn.Font.FontFamily, 9.75f);
					btn.Width = 240;
					btn.Height = 40;
				}

				pnlLeft.Width = 240;

				foreach (ToolStripItem item in mnuMain.Items)
				{
					if (!mainButtons.Contains(item))
					{
						if (item.Tag == null || item.Tag.ToString() == "") item.Visible = true;
					}
				}

				mnuSubscriptions.Visible = true;
				mnuMoreOptions.Visible = true;
				btnMenu.Tag = "open";
			}

			pnlLeft.ResumeLayout();
		}

		private void txtSearch_Resize(object sender, EventArgs e)
		{
			if (txtSearch.Width < 80)
			{
				txtSearch.Visible = false;
				btnSearch.Visible = false;
				txtSearch.PerformLayout();
				btnSearch.PerformLayout();
			}
			else
			{
				txtSearch.Visible = true;
				btnSearch.Visible = true;
			}
		}		
	}
}
