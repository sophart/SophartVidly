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
        public ActionResult Index(int? pageId, string sortBy)
        {
            if (!pageId.HasValue)
                pageId = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content($"pageId = {pageId} & sortBy = {sortBy}");
        }

        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"Movies for year: {year} and month: {month}");
        }
    }
}