using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallpapers.Entities;

namespace Infrastructure.DataAccess
{
    public class WallpaperRepository : AuditableRepository<Wallpaper>, IWallpaperRepository
    {
        private readonly AppDbContext _dbContext;

        public WallpaperRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override Wallpaper Get(int id)
        {
            return base.Get(id);
        }

        public IReadOnlyList<Wallpaper> GetAll()
        {
            return _dbContext.Wallpapers.ToList();
        }

        public IReadOnlyList<Wallpaper> GetWallpapersByCategory(string category)
        {
            return _dbContext.Wallpapers.Where(x => x.Name.ToLower().Contains(category.ToLower())).ToList();
        }

        void IWallpaperRepository.Delete(Wallpaper wallpaper)
        {
            throw new NotImplementedException();
        }
    }
}
