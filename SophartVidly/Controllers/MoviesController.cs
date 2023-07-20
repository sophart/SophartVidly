using SophartVidly.Models;
using SophartVidly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SophartVidly.Controllers
{
    public class MoviesController : Controller
    {

        private readonly List<Movie> _movies;

        public MoviesController()
        {
            _movies = GetMovies();
        }

        private List<Movie> GetMovies()
        {
            var movies = new List<Movie>() { 
                new Movie() { Id = 1,Name = "Die Hard"},
                new Movie(){Id = 2, Name = "Avenger"}
            };

            return movies;
        }

        public ActionResult Index()
        {
           return View(_movies);
        }

        public ActionResult Detail(int id)
        {
            var movie = _movies.SingleOrDefault(m => m.Id == id);

            return View(movie);
        }

    }
}