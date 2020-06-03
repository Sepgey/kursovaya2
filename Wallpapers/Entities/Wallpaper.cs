using System;
using System.Collections.Generic;
using System.Text;

namespace Wallpapers.Entities
{
    public enum ImageFormat
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

        public ImageFormat Format { get; set; }
        public Wallpaper(int id, string name, string section, int xres, int yres, int categoryId, ImageFormat format) : base(id)
        {
            Name = name;
            Section = section;
            XResolution = xres;
            YResolution = yres;
            CategoryId = categoryId;
            Format = format;
        }
        public Wallpaper()
        {

        }
    }
}
