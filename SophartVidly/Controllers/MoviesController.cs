using SophartVidly.Models;
using SophartVidly.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SophartVidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(x => x.Genre).ToList();

            return View(movies);
        }

        public ActionResult Detail(int id)
        {
            var movie = _context.Movies.Include(x => x.Genre).SingleOrDefault(m => m.Id == id);

            return View(movie);
        }

        protected override void Dispose(bool disposing)
        {

            _context.Dispose();
        }
    }
}