using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallpapers.Entities;
using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebWallpaper.Controllers
{
    [Route("html/[controller]")]
    public class HtmlWallpaperController : Controller
    {
        private IWallpaperRepository _wallpaperRepository { get; set; }

        public HtmlWallpaperController(IWallpaperRepository wallpaperRepository)
        {
            _wallpaperRepository = wallpaperRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_wallpaperRepository.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View(_wallpaperRepository.Get(id));
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Wallpaper wallpaper)
        {
            try
            {
                _wallpaperRepository.Add(wallpaper);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("update/{id}")]
        public ActionResult Edit(int id)
        {
            return View(_wallpaperRepository.Get(id));
        }

        [HttpPost("update/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Wallpaper wallpaper)
        {
            try
            {
                _wallpaperRepository.Update(wallpaper);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
