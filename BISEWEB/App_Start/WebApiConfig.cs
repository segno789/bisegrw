using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using System.Web.Http;
using System.Web.Mvc;

namespace BISEWEB
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "MyWebAPI", action = "GetNameByID", id = UrlParameter.Optional }
            );
        }
    }
}
