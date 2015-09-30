﻿using System;
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
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<Speciality> Specialities { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<File> Files { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<UserMessage> UserMessages { get; set; }

		public EFDataContext(string stringConnection)
			: base(stringConnection)
		{
		}
	}
}