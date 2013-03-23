using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoundCloud.Models;

namespace SoundCloud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            List<Song> songs = new List<Song>() { 
                new Song() { ID = 1, Title = "Put a Light On", ArtistName = "Generationals", AlbumName = "Album 1", Genre = "Rock", Year = 2013, FileName = @"C:\Music\LoremIpsum2.mp3" },
                new Song() { ID = 2, Title = "Pretend You Love Me", ArtistName = "Generationals", AlbumName = "Album 1", Genre = "Rock", Year = 2013, FileName = @"C:\Music\LoremIpsum2.mp3" },
                new Song() { ID = 3, Title = "Beat Rolls On", ArtistName = "Generationals", AlbumName = "Album 1", Genre = "Rock", Year = 2013, FileName = @"C:\Music\LoremIpsum2.mp3" },
                new Song() { ID = 4, Title = "Your Enemies Are My Enemies", ArtistName = "Generationals", AlbumName = "Album 1", Genre = "Rock", Year = 2013, FileName = @"C:\Music\LoremIpsum2.mp3" },
                new Song() { ID = 5, Title = "Come Togethe", ArtistName = "The Beatles", AlbumName = "Greatest Hists", Genre = "Pop", Year = 1970, FileName = @"C:\Music\LoremIpsum2.mp3" }
            };

            return View(songs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Top5()
        {
            ViewBag.Message = "This is the Top 5.";

            return View();
        }
    }
}
