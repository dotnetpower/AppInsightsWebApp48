using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.ApplicationInsights;

namespace AppInsightsWebApp48
{
    public class MvcApplication : System.Web.HttpApplication
    {
        TelemetryClient telemetryClient = new TelemetryClient();

        protected void Application_Start()
        {
            telemetryClient.TrackTrace("Application_Start1");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
