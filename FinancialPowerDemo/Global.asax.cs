using System.Web.Mvc;
using System.Web.Routing;
using FinancialPowerDemo.Configuration;

namespace FinancialPowerDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BootStrap.Start();
        }

        protected void Application_BeginRequest()
        {
            SessionFactory.BeginRequest();
        }

        protected void Application_EndRequest()
        {
            SessionFactory.EndRequest();
        }
    }
}