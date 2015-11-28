using System;
using FileSocialNetwork.DataAccess.SqlDataAccess.DataContexts;
using FileSocialNetwork.DataAccess.SqlDataAccess.UnitOfWorks;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.DataAccess.SqlDataAccessTest
{
	class Program
	{
		static void Main()
		{
			fullDbContext("DBConnection");
			//fullUnitOfWork("DBConnection");

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

				User u1 = new User()
				{
					Group = g1,
					FirstName = "FirstName",
					LastName = "LastName",
			
				};

				User u2 = new User()
				{
					Group = g1,
					FirstName = "FirstName2",
					LastName = "LastName2",
				};

				User u3 = new User()
				{
					Group = g2,
					FirstName = "FirstName3",
					LastName = "LastName3",
				};
				db.Users.Add(u1);
				db.Users.Add(u2);
				db.Users.Add(u3);
				db.SaveChanges();

				FileCategory fileCategory = new FileCategory()
				{
					Name = "category1"
				};
				db.FileCategories.Add(fileCategory);
				db.SaveChanges();

				File f1 = new File()
				{
					User = u1,
					Subject = sub1,
					FileCategory = fileCategory,
					Description = "f waf wefaww",
					DateOfCreate = DateTime.Now,
					Name = "ffffff"
				};
				File f2 = new File()
				{
					User = u2,
					Subject = sub1,
					FileCategory = fileCategory,
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

				Like l1 = new Like()
				{
					User = u3,
					File = f1
				};
				Like l2 = new Like()
				{
					User = u3,
					File = f2
				};
				Like l3 = new Like()
				{
					User = u1,
					File = f2
				};
				db.Lies.Add(l1);
				db.Lies.Add(l2);
				db.Lies.Add(l3);
				db.SaveChanges();
			}
		}

		//static void fullUnitOfWork(string connectionString)
		//{
		//	using (var uow = new UnitOfWork(connectionString))
		//	{
		//		Faculty f = new Faculty()
		//		{
		//			Title = "Faculty1"
		//		};
		//		uow.Faculties.Create(f);
		//		uow.Save();

		//		Cathedra c1 = new Cathedra()
		//		{
		//			Title = "Cathedra1",
		//			Faculty = f
		//		};
		//		Cathedra c2 = new Cathedra()
		//		{
		//			Title = "Cathedra2",
		//			Faculty = f
		//		};
		//		uow.Cathedras.Create(c1);
		//		uow.Cathedras.Create(c2);
		//		uow.Save();

		//		Subject sub1 = new Subject()
		//		{
		//			Title = "sub1",
		//			Cathedra = c1
		//		};
		//		uow.Subjects.Create(sub1);
		//		uow.Save();

		//		Speciality sp1 = new Speciality()
		//		{
		//			Title = "Speciality1",
		//			Number = "dddddd",
		//			Cathedra = c1
		//		};
		//		uow.Specialities.Create(sp1);
		//		uow.Save();

		//		Group g1 = new Group()
		//		{
		//			Number = "107221",
		//			Speciality = sp1
		//		};
		//		Group g2 = new Group()
		//		{
		//			Number = "107222",
		//			Speciality = sp1
		//		};
		//		uow.Groups.Create(g1);
		//		uow.Groups.Create(g2);
		//		uow.Save();

		//		Role r1 = new Role()
		//		{
		//			Name = "superadmin"
		//		};
		//		Role r2 = new Role()
		//		{
		//			Name = "admin"
		//		};
		//		Role r3 = new Role()
		//		{
		//			Name = "user"
		//		};
		//		uow.UserRoles.Create(r1);
		//		uow.UserRoles.Create(r2);
		//		uow.UserRoles.Create(r3);
		//		uow.Save();

		//		User u1 = new User()
		//		{
		//			Group = g1,
		//			FirstName = "FirstName",
		//			Email = "Email",
		//			LastName = "LastName",
		//			Login = "Login",
		//			YearAmission = 3,
		//			YearGraduation = 55,
		//			PhoneNumber = "PhoneNumber",
		//			PasswordHash = "PasswordHash",
		//		};
		//		u1.Roles.Add(r1);
		//		u1.Roles.Add(r2);
		//		u1.Roles.Add(r3);

		//		User u2 = new User()
		//		{
		//			Group = g1,
		//			FirstName = "FirstName2",
		//			Email = "Email2",
		//			LastName = "LastName2",
		//			Login = "Login2",
		//			YearAmission = 32,
		//			YearGraduation = 552,
		//			PhoneNumber = "PhoneNumber2",
		//			PasswordHash = "PasswordHash2",
		//		};
		//		u2.Roles.Add(r2);
		//		u2.Roles.Add(r3);

		//		User u3 = new User()
		//		{
		//			Group = g2,
		//			FirstName = "FirstName3",
		//			Email = "Email3",
		//			LastName = "LastName3",
		//			Login = "Login3",
		//			YearAmission = 33,
		//			YearGraduation = 553,
		//			PhoneNumber = "PhoneNumber3",
		//			PasswordHash = "PasswordHash3",
		//		};
		//		u3.Roles.Add(r3);

		//		uow.Users.Create(u1);
		//		uow.Users.Create(u2);
		//		uow.Users.Create(u3);
		//		uow.Save();

		//		File f1 = new File()
		//		{
		//			User = u1,
		//			Subject = sub1,
		//			Description = "f waf wefaww",
		//			DateOfCreate = DateTime.Now,
		//			Name = "ffffff"
		//		};
		//		File f2 = new File()
		//		{
		//			User = u2,
		//			Subject = sub1,
		//			Description = "f2222222 waf wefaww",
		//			DateOfCreate = DateTime.Now,
		//			Name = "ffff2222222"
		//		};
		//		uow.Files.Create(f1);
		//		uow.Files.Create(f2);
		//		uow.Save();

		//		Message m1 = new Message()
		//		{
		//			Text = "mess1",
		//			DateOfCreate = DateTime.Now,
		//			User = u1,
		//			UserMessage = new UserMessage()
		//			{
		//				User = u2
		//			}
		//		};
		//		uow.Messages.Create(m1);
		//		uow.Save();
		//	}
		//}
	}
}
