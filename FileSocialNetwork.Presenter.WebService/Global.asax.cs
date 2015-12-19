using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FileSocialNetwork.Presenter.WebService
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
   
            //    HttpContext.Current.Response.AddHeader();

            //   HttpContext.Current.Response.Headers.Set("Access-Control-Allow-Origin", "*");

            //if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            //{
            //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "*");

            //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "*");
            //    HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
            //    HttpContext.Current.Response.End();
            //}
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            if (!HttpContext.Current.Response.Headers.AllKeys.Contains("Access-Control-Allow-Origin"))
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            }
        }
	}
}
