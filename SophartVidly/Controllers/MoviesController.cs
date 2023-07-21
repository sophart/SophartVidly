using SophartVidly.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using SophartVidly.ViewModels.Movies;

namespace SophartVidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

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


        public ActionResult Create()
        {
            var genres = _context.Genres.ToList();

            var movie = new MovieFormViewModel()
            {
                Genres = genres
            };

            return View("MovieForm", movie);
        }

        public ActionResult Update(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            var genres = _context.Genres.ToList();

            var movieForForm = new MovieFormViewModel()
            {
                Id = movie.Id,
                GenreId = movie.GenreId,
                Name = movie.Name,
                Genres = genres,
                NumberInStock = movie.NumberInStock,
                ReleaseDate = movie.ReleaseDate
            };


            return View("MovieForm", movieForForm);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}