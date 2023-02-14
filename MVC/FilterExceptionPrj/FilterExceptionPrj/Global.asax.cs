using FilterExceptionPrj.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FilterExceptionPrj
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // handling diffrent errors at the global level
            //  GlobalFilters.Filters.Add(new HandleErrorAttribute());

            //register all filters using a filterconfig class, then write as below
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
