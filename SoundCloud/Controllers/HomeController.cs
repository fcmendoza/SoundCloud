using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoundCloud.Models;
using SoundCloud.DataAccess.Repositories;

namespace SoundCloud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            List<Song> songs = _repo.GetSongs();

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

            List<Song> songs = _repo.GetTop5();

            return View(songs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            _repo.SaveSong(song);
            return RedirectToAction("Index");
        }

        private SongRepository _repo = new SongRepository();
    }
}
