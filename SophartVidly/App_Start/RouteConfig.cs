﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SophartVidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Routes orders are matter
            // Be more specific to more generic

            // enable attribute route
            routes.MapMvcAttributeRoutes();


            // Define custom routes
            //routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "movie/released/{year}/{month}",
            //    defaults: new { controller = "Movie", action = "ByReleaseDate" },
            //    constraints: new {year = @"\d{4}", month = @"\d{2}"}
            //    );

            // below is the default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
