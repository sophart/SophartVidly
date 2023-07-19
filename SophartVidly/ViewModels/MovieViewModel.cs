using SophartVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SophartVidly.ViewModels
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}