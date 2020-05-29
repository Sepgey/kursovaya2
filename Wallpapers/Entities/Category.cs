﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Wallpapers.Entities
{
	public class Category : AuditableEntity
	{
		public string categoryName { get; set; }

		public string description { get; set; }

		public ICollection<Wallpaper>  Wallpapers { get; set; }
	}
}