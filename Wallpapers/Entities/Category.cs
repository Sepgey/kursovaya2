using System;
using System.Collections;

namespace Wallpapers.Entities
{
	public class Category : AuditableEntity
	{
		public string categoryName { get; set; }

		public string description { get; set; }

		public IList  wallpapers { get; set; }
	}
}