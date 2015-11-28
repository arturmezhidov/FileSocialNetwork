using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.BusinessLogic.BusinessComponents;
using FileSocialNetwork.BusinessLogic.Contracts;
using Ninject.Modules;

namespace FileSocialNetwork.Shared.DependencyInjection
{
	public class BusinessModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IFacultyService>().To<FacultyService>();
			Bind<IRatingService>().To<RatingService>();
		}
	}
}
