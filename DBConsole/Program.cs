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
        private static AppDbContext _appContext;
        private static IWallpaperRepository _wallpaperRepository;
        private static IUserRepository _userRepository;

        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _wallpaperRepository = new WallpaperRepository(_appContext);
            _userRepository = new UserRepository(_appContext);
        }

        public static void Main(string[] args)
        {
            Wallpaper wallpaper = new Wallpaper(0,"Tree", "Nature", 1920, 1080, 1, ImageFormat.PNG);
            User user = new User(0,"Sepgey", "Tarberdyev", "SSSSeryoga");

            _wallpaperRepository.Add(wallpaper);
            _userRepository.Add(user);

            Console.WriteLine($"Id: {wallpaper.Id}, Name: {wallpaper.Name}, Section: {wallpaper.Section}, Resolution: {wallpaper.XResolution}x{wallpaper.YResolution}, Category: {wallpaper.CategoryId}, Type: {wallpaper.Format}");
            Console.ReadLine();
        }
    }
}
