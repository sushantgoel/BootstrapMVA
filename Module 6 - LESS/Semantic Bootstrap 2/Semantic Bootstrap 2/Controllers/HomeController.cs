using Semantic_Bootstrap_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semantic_Bootstrap_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var album = GetAlbum();

            return View(album);
        }

        private object GetAlbum()
        {
            return new Album
            {
                BandName = "The Best Band",
                ExpertReview = "This is my favorite album.",
                Title = "Green",
                Tracks = new List<Track> {
                    new Track { Title = "The hit", Duration = new TimeSpan(0,3,5) },
                    new Track { Title = "That forgettable one", Duration = new TimeSpan(0,3,5) }
                }
            };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}