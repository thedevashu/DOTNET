using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ORM
{
    public class MvcApplication : System.Web.HttpApplication
    {
      
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
