using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.DataAccess.SqlDataAccess.DataContexts
{
	public class EFDataContext : DbContext
	{
		public DbSet<Faculty> Faculties { get; set; }
		public DbSet<Cathedra> Cathedras { get; set; }

		public EFDataContext(string stringConnection) : base(stringConnection)
		{
		}
	}
}
