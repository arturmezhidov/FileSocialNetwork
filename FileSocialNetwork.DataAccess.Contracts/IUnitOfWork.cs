using System;

using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.DataAccess.Contracts
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<Faculty> Faculties { get; }
		IRepository<Cathedra> Cathedras { get; }
		IRepository<Speciality> Specialities { get; }
		IRepository<Subject> Subjects { get; }
		IRepository<Group> Groups { get; }
		IRepository<UserRole> UserRoles { get; }
		IRepository<User> Users { get; }
		IRepository<File> Files { get; }
		IRepository<Message> Messages { get; }
		IRepository<UserMessage> UserMessages { get; }
	
		void Save();
	}
}
