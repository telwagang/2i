using _2i.App_Start;
using _2i.Helpers;
using API.Helpers;
using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _2i
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
           
            GlobalConfiguration.Configure(WebApiConfigcs.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //WebApiConfigcs.Register(GlobalConfiguration.Configuration);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            

            Sys.Get<ISettings>().SetConnectionString(Helpers._2iHelper.GetAppSettingString("MongoDBConnectionString"));
            Sys.Get<ISettings>().SetDataBase(Helpers._2iHelper.GetAppSettingString("MongoDBDataBaseName"));
        }
    }
}
