using SophartVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SophartVidly.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            var movie = new Movie()
            {
                Name = "Die Hard!"
            };

            return View(movie);
        }
    }
}