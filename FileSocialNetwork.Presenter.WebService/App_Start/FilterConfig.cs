using System.Web;
using System.Web.Mvc;

namespace FileSocialNetwork.Presenter.WebService
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
