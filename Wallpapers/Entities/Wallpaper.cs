using System;
using System.Collections.Generic;
using System.Text;

namespace Wallpapers.Entities
{
    public enum Types
    {
        RAW = 1,
        JPEG,
        GIF,
        PNG,
        TIFF,
        BMP
    }
    public class Wallpaper : AuditableEntity
    {

        public string Name { get; set; }

        public string Section { get; set; }

        public int XResolution { get; set; }

        public int YResolution { get; set; }

        public int CategoryId { get; set; }

        Types Types;
        public Wallpaper(string name, string section,  int xres, int yres, int categoryId, Types types)
        {
            Name = name;
            Section = section;
            XResolution = xres;
            YResolution = yres;
            CategoryId = categoryId;
            Types = types;
        }
    }
}
