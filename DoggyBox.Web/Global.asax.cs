using DoggyBox.Infrastructure.AutoMapper;
using DoggyBox.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DoggyBox.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEnginesConfig.RegisterRoutes(ViewEngines.Engines);
            AutoMapperConfig.RegisterMappings(new AutoMapperInitializer(Assembly.GetExecutingAssembly()));
        }
    }
}
