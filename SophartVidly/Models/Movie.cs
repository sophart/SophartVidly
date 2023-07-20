using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SophartVidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        public Genre Genre { get; set; }
    }
}