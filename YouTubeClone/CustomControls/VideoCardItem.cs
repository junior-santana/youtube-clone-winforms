using System;
using System.Drawing;
using System.Windows.Forms;

namespace YouTubeClone.CustomControls
{
	public partial class VideoCardItem : UserControl
	{
		private DateTime _publishedDate = DateTime.Now;
		private ulong _views = 999999;

		public VideoCardItem()
		{
			InitializeComponent();
		}

		public string ChannelThumbnail { get => picChannelThumbnail.ImageLocation; set => picChannelThumbnail.LoadAsync(value); }

		public string ChannelName { get => lblChannelName.Text; set => lblChannelName.Text = value; }

		public string Thumbnail { get => picVideoThumbnail.ImageLocation; set => picVideoThumbnail.LoadAsync(value); }

		public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }

		public DateTime PublishedDate
		{
			get => _publishedDate;
			set {
				_publishedDate = value;
				UpdateVideoInfo();
			}
		}

		public ulong Views
		{
			get => _views;
			set {
				_views = value;
				UpdateVideoInfo();
			}
		}

		void UpdateVideoInfo()
		{
			lblVideoInfo.Text = FormatViewsText() + " - " + FormatPublishedTimeText();
		}

		string FormatViewsText()
		{
			string viewsText = "";

			if (_views >= 1000000)
			{
				viewsText = Math.Round((double)_views / 1000000, 1).ToString() + "M";
			}
			else if (_views >= 1000)
			{
				viewsText = ((int)_views / 1000).ToString() + "K";
			}
			else
			{
				viewsText = _views.ToString();
			}

			viewsText += " views";

			return viewsText;
		}

		string FormatPublishedTimeText()
		{
			string publishedTimeText = "";

			TimeSpan timeDiff = (DateTime.Now - _publishedDate);

			if (timeDiff.Days >= 365)
			{
				publishedTimeText = ((int)timeDiff.Days / 365).ToString();
				publishedTimeText += publishedTimeText == "1" ? " year" : " years";
			}
			else if (timeDiff.Days > 30)
			{
				publishedTimeText = ((int)timeDiff.Days / 30).ToString();
				publishedTimeText += publishedTimeText == "1" ? " month" : " months";
			}
			else if (timeDiff.Days >= 1)
			{
				publishedTimeText = timeDiff.Days.ToString();
				publishedTimeText += publishedTimeText == "1" ? " month" : " months";
			}
			else if (timeDiff.Hours >= 1)
			{
				publishedTimeText = timeDiff.Hours.ToString();
				publishedTimeText += publishedTimeText == "1" ? " hour" : " hours";
			}
			else if (timeDiff.Minutes >= 1)
			{
				publishedTimeText = timeDiff.Minutes.ToString();
				publishedTimeText += publishedTimeText == "1" ? " minute" : " minutes";
			}
			else
			{
				publishedTimeText = "1 minute";
			}

			publishedTimeText += " ago";

			return publishedTimeText;
		}

	}
}
