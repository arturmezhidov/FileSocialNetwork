using System;

using FileSocialNetwork.DataAccess.Contracts;
using FileSocialNetwork.DataAccess.SqlDataAccess.DataContexts;
using FileSocialNetwork.DataAccess.SqlDataAccess.Repositories;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.DataAccess.SqlDataAccess.UnitOfWorks
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly EFDataContext context;
		private IRepository<Faculty> faculties;
		private IRepository<Cathedra> cathedras;
		private IRepository<Speciality> specialities;
		private IRepository<Subject> subjects;
		private IRepository<Group> groups;
		private IRepository<UserRole> userRoles;
		private IRepository<User> users;
		private IRepository<File> files;
		private IRepository<Message> messages;
		private IRepository<UserMessage> userMessages;
		private bool disposed;

		public UnitOfWork(string connectionString)
		{
			context = new EFDataContext(connectionString);
		}

		#region Implementation of IUnitOfWork

		public IRepository<Faculty> Faculties
		{
			get
			{
				return faculties ?? (faculties = new BaseRepository<Faculty>(context));
			}
		}

		public IRepository<Cathedra> Cathedras
		{
			get
			{
				return cathedras ?? (cathedras = new BaseRepository<Cathedra>(context));
			}
		}

		public IRepository<Speciality> Specialities
		{
			get
			{
				return specialities ?? (specialities = new BaseRepository<Speciality>(context));
			}
		}

		public IRepository<Subject> Subjects
		{
			get
			{
				return subjects ?? (subjects = new BaseRepository<Subject>(context));
			}
		}

		public IRepository<Group> Groups
		{
			get
			{
				return groups ?? (groups = new BaseRepository<Group>(context));
			}
		}

		public IRepository<UserRole> UserRoles
		{
			get
			{
				return userRoles ?? (userRoles = new BaseRepository<UserRole>(context));
			}
		}

		public IRepository<User> Users
		{
			get
			{
				return users ?? (users = new BaseRepository<User>(context));
			}
		}

		public IRepository<File> Files
		{
			get
			{
				return files ?? (files = new BaseRepository<File>(context));
			}
		}

		public IRepository<Message> Messages
		{
			get
			{
				return messages ?? (messages = new BaseRepository<Message>(context));
			}
		}

		public IRepository<UserMessage> UserMessages
		{
			get
			{
				return userMessages ?? (userMessages = new BaseRepository<UserMessage>(context));
			}
		}

		public void Save()
		{
			context.SaveChanges();
		}

		#endregion

		#region Implementation of IDisposable

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					context.Dispose();
				}
				disposed = true;
			}
		}

		#endregion
	}
}
