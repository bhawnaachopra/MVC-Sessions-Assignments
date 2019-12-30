using System.Web.Mvc;
using System.Web.Routing;

namespace CustomRoute
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Custom Route
            routes.MapRoute(
                name: "Custom",
                url: "{controller}/{action}/{name}/{id}",
                defaults: new { controller = "Home", action = "Custom" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
