using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity.ModelConfiguration.Conventions;
using BoatsMontenegro.Models;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using BoatsMontenegro.BaseBase;
using Newtonsoft.Json;
using System.Web.Security;



namespace BoatsMontenegro
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
              
    }
}
