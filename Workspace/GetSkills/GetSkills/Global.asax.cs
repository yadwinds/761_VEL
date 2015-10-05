using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GetSkills
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //This configration squash scripts to clients, minimizing file size and preventing hacking.
            BundleTable.EnableOptimizations = true;
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Application.Lock();      //临界变量,使用加锁功能,其他用户不能访问。
            Application["count"] = 0;
            Application.UnLock();     //临界变量被解锁。

        }

        protected void Application_End()
        {

        }
    }
}
