using System;
using System.Collections.Generic;
using System.Text;
using Wallpapers.Entities;

namespace Infrastructure.DataAccess
{
    public interface IWallpaperRepository
    {
        IReadOnlyList<Wallpaper> GetAll();
        Wallpaper Get(int id);
        void Add(Wallpaper wallpaper);  
        IReadOnlyList<Wallpaper> GetWallpapersByName(string name);
    }
}
