using Wallpapers.Entities;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using Microsoft.Extensions.Options;
using EO.Internal;

namespace DBConsole
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext> 
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        OptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WallpaperDb;Trusted_Connection=True;", b => b.MigrationsAssembly("Infrastructure"));
            return new AppDbContext(optionsBuilder.Options);
    }

    class Program
    {
        private static readonly AppDbContext _appContext;
        private static IWallpaperRepository _wallpaperRepository;
        private static IUserRepository _authorRepository;
        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _authorRepository = new UserRepository(_appContext);
            _wallpaperRepository = new WallpaperRepository(_appContext);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start!");

            User author = new User("Александр", "Пушкин", "Сергеевич");
            _authorRepository.Add(author);
            Wallpaper wallpaper= new Wallpaper();
            _wallpaperRepository.Add(wallpaper);
        }
    }
}
