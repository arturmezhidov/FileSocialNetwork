using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.DataAccess.Contracts;
using FileSocialNetwork.DataAccess.SqlDataAccess.UnitOfWorks;
using Ninject.Modules;

namespace FileSocialNetwork.Shared.DependencyInjection
{
	public class DataAccessModule : NinjectModule
	{
		private readonly string connectionString;

		public DataAccessModule(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public override void Load()
		{
			Bind<IUnitOfWork>()
				.To<UnitOfWork>()
				.WithConstructorArgument(connectionString);
		}
	}
}
