using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.DataAccess.SqlDataAccess.DataContexts;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.DataAccess.SqlDataAccessTest
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new EFDataContext("DBConnection"))
			{
				Faculty f = new Faculty()
				{
					Title = "Faculty1"
				};
				db.Faculties.Add(f);
				db.SaveChanges();

				Cathedra c1 = new Cathedra()
				{
					Title = "Cathedra1",
					Faculty = f
				};
				Cathedra c2 = new Cathedra()
				{
					Title = "Cathedra2",
					Faculty = f
				};
				db.Cathedras.Add(c1);
				db.Cathedras.Add(c2);
				db.SaveChanges();
			}
		}
	}
}
