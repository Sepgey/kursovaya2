using System;
using System.Collections.Generic;
using System.Text;

namespace Wallpapers.Entities
{
   public class Wallpaper : AuditableEntity
    {
        public string Name { get; set; }
        public string Section { get; set; }
        public string Type { get; set; }
        public int XResolution { get; set; }
        public int YResolution { get; set; }
    }
}
