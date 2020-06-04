﻿using System;
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
        void Delete(Wallpaper wallpaper);
        void Update(Wallpaper wallpaper);
        IReadOnlyList<Wallpaper> GetWallpapersByCategory(string category);
    }
}
