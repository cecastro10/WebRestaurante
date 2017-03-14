using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebRestauranteFinal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Restaurantes",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Restaurantes", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "Pratos",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Pratos", action = "Index", id = UrlParameter.Optional }
          );
        }
    }
}
