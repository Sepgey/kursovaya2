using System;
using System.Collections.Generic;
using System.Text;

namespace Wallpapers.Entities
{
   public class Wallpaper : AuditableEntity
    {
        public int WallpapersId { get; set; }

        public string Name { get; set; }

        public string Section { get; set; }

        enum Types 
        {
            RAW = 1,
            JPEG,
            GIF,
            PNG,
            TIFF,
            BMP
        }

        public int XResolution { get; set; }

        public int YResolution { get; set; }

        public int categoryId { get; set; }

        public Wallpaper(string name, string section, string type, int xres, int yres)
        {
            Name = name;
            Section = section;
            Type = type;
            XResolution = xres;
            YResolution = yres;
        }
    }
}
