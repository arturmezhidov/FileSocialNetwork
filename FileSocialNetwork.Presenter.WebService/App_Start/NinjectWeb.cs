using FileSocialNetwork.Presenter.WebService;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWeb), "Start")]

namespace FileSocialNetwork.Presenter.WebService
{
	public static class NinjectWeb 
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
        }
    }
}
