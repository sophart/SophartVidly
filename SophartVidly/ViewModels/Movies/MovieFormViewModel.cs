using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SophartVidly.Models;

namespace SophartVidly.ViewModels.Movies
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        public int GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public int NumberInStock { get; set; }
    }
}