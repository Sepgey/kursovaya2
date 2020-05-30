using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallpapers.Entities;

namespace Infrastructure.DataAccess
{
    class WallpaperRepository : AuditableRepository<Wallpaper>, IWallpaperRepository
    {
       
    }
}
