using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.DataAccess.Contracts;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.BusinessLogic.BusinessComponents
{
	public class UserService : IUserService
	{
		private IUnitOfWork uow;

		public UserService(IUnitOfWork uow)
		{
			this.uow = uow;
		}

		public User Create(User user)
		{
			User tmpUser = uow.Users.Create(user);
			uow.Save();
			return tmpUser;
		}
	}
}
