using System;
using System.Collections.Generic;
using System.Configuration;
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
			fullDbContext("DBConnection");
		}

		static void fullDbContext(string connectionString)
		{
			using (var db = new EFDataContext(connectionString))
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

				Subject sub1 = new Subject()
				{
					Title = "sub1",
					Cathedra = c1
				};
				db.Subjects.Add(sub1);
				db.SaveChanges();

				Speciality sp1 = new Speciality()
				{
					Title = "Speciality1",
					Number = "dddddd",
					Cathedra = c1
				};
				db.Specialities.Add(sp1);
				db.SaveChanges();

				Group g1 = new Group()
				{
					Number = "107221",
					Speciality = sp1
				};
				Group g2 = new Group()
				{
					Number = "107222",
					Speciality = sp1
				};
				db.Groups.Add(g1);
				db.Groups.Add(g2);
				db.SaveChanges();

				UserRole r1 = new UserRole()
				{
					Name = "superadmin"
				};
				UserRole r2 = new UserRole()
				{
					Name = "admin"
				};
				UserRole r3 = new UserRole()
				{
					Name = "user"
				};
				db.UserRoles.Add(r1);
				db.UserRoles.Add(r2);
				db.UserRoles.Add(r3);
				db.SaveChanges();

				User u1 = new User()
				{
					Group = g1,
					FirstName = "FirstName",
					Email = "Email",
					LastName = "LastName",
					Login = "Login",
					YearAmission = 3,
					YearGraduation = 55,
					PhoneNumber = "PhoneNumber",
					PasswordHash = "PasswordHash",
					UserRole = r2
				};
				User u2 = new User()
				{
					Group = g1,
					FirstName = "FirstName2",
					Email = "Email2",
					LastName = "LastName2",
					Login = "Login2",
					YearAmission = 32,
					YearGraduation = 552,
					PhoneNumber = "PhoneNumber2",
					PasswordHash = "PasswordHash2",
					UserRole = r3
				};
				User u3 = new User()
				{
					Group = g2,
					FirstName = "FirstName3",
					Email = "Email3",
					LastName = "LastName3",
					Login = "Login3",
					YearAmission = 33,
					YearGraduation = 553,
					PhoneNumber = "PhoneNumber3",
					PasswordHash = "PasswordHash3",
					UserRole = r3
				};
				db.Users.Add(u1);
				db.Users.Add(u2);
				db.Users.Add(u3);
				db.SaveChanges();

				File f1 = new File()
				{
					User = u1,
					Subject = sub1,
					Description = "f waf wefaww",
					DateOfCreate = DateTime.Now,
					Name = "ffffff"
				};
				File f2 = new File()
				{
					User = u2,
					Subject = sub1,
					Description = "f2222222 waf wefaww",
					DateOfCreate = DateTime.Now,
					Name = "ffff2222222"
				};
				db.Files.Add(f1);
				db.Files.Add(f2);
				db.SaveChanges();

				Message m1 = new Message()
				{
					Text = "mess1",
					DateOfCreate = DateTime.Now,
					User = u1,
					UserMessage = new UserMessage()
					{
						User = u2
					}
				};
				db.Messages.Add(m1);
				db.SaveChanges();
			}
		}
	}
}
