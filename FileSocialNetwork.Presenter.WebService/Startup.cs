using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
 
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(FileSocialNetwork.Presenter.WebService.Startup))]

namespace FileSocialNetwork.Presenter.WebService
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}
