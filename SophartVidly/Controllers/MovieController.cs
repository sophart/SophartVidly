using SophartVidly.Models;
using SophartVidly.ViewModels;
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

            var customers = new List<Customer>()
            {
             new Customer  { Id = Guid.NewGuid(), Name ="Sophart"},
             new Customer  { Id = Guid.NewGuid(), Name = "Lakkhena"},
             new Customer  { Id = Guid.NewGuid(), Name = "Panhakvoan"},
            };

            var viewModel = new MovieViewModel
            {
                Customers = customers,
                Movie = movie
            };

            return View(viewModel);
        }

    }
}