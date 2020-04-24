using System;

namespace YouTubeClone.Models
{
	class VideoDetails
	{
		public string ChannelThumbnail { get; set; }
		public string ChannelName { get; set; }
		public string Thumbnail { get; set; }
		public string Title { get; set; }
		public DateTime PublishedDate { get; set; }
		public ulong Views { get; set; }
	}
}
