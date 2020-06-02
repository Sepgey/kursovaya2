using Wallpapers.Entities;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Channels;

namespace DBConsole
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WallpaperDB;Trusted_Connection=True;", b => b.MigrationsAssembly("Infrastructure"));
            return new AppDbContext(optionsBuilder.Options);
        }
    }

    class Program
    {
        private static readonly AppDbContext _appContext;
        private static IWallpaperRepository _wallpaperRepository;
        private static IUserRepository _userRepository;

        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _wallpaperRepository = new WallpaperRepository(_appContext);
        }

        static void Main(string[] args)
        {
            using (var context = new AppDbContext()) 
            {
                var wallaper = new Wallpaper()
                {
                    Id = 1,
                    Name = "Tree",
                    Section = "Nature",
                    XResolution = 1080,
                    YResolution = 1920,
                    CategoryId = 1,
                    _Types = (Types)4
                };

                context.Wallpapers.Add(wallaper);
                context.SaveChanges();

                Console.WriteLine($"Id: {wallaper.Id}, Name: {wallaper.Name}, Section: {wallaper.Section}, Resolution: {wallaper.XResolution}x{wallaper.YResolution}, Category: {wallaper.CategoryId}, Type: {wallaper._Types}");
                Console.ReadLine();
            }
        }
    }
}
