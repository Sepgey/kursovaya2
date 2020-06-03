using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Wallpapers.Entities;

namespace Infrastructure.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Wallpaper> Wallpapers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}