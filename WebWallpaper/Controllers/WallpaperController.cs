using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallpapers.Entities;

namespace WebWallpaper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WallpaperController : ControllerBase
    {
        private IWallpaperRepository _wallpaperRepository { get; set; }

        public WallpaperController(IWallpaperRepository wallpaperRepository)
        {
            _wallpaperRepository = wallpaperRepository;
        }

        [HttpGet]
        public IEnumerable<Wallpaper> Get()
        {
            return _wallpaperRepository.GetAll();
        }


        [HttpGet("{id}")]
        public Wallpaper Get(int id)
        {
            return _wallpaperRepository.Get(id);
        }


        [HttpPost]
        public ActionResult Post([FromBody] Wallpaper wallpaper)
        {
            _wallpaperRepository.Add(wallpaper);
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Wallpaper wallpaper)
        {
            _wallpaperRepository.Update(wallpaper);
            return Ok();
        }
    }
}
