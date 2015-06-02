using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace automapper.demo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Mapping Example One",
                url: "mappingExampleOne",
                defaults: new { controller = "Home", action = "MappingExampleOne" }
            );

            routes.MapRoute(
                name: "Mapping Example Two",
                url: "mappingExampleTwo",
                defaults: new { controller = "Home", action = "MappingExampleTwo" }
            );

            routes.MapRoute(
                name: "Mapping Example Three",
                url: "mappingExampleThree",
                defaults: new { controller = "Home", action = "MappingExampleThree" }
            );

            routes.MapRoute(
                name: "Mapping Example Four",
                url: "mappingExampleFour",
                defaults: new { controller = "Home", action = "MappingExampleFour" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
