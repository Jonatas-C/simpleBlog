using simpleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace simpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new string[] { typeof(PostsController).Namespace };
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Login", url: "login", defaults: new { controller = "Auth", action = "Login" }, namespaces: namespaces);

            routes.MapRoute(namespaces: namespaces, name: "Home", url: "", defaults: new { controller = "Posts", action = "Index" });
        }
    }
}