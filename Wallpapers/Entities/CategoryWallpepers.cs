using System;



namespace Wallpapers.Entities
{
	public class CategoryWallpepers
	{
		public int id { get; set; }

		public string categiryName { get; set; }

		public string description { get; set; }

		public List<Wallpapers> wallpapers { get; set; }

	}
}