using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.BusinessLogic.Contracts
{
	public interface IFileService
	{
		IEnumerable<FileCategory> GetAllCategory();
        File CreateFile(string name, string description, int userId, int categoryId, int subjectId);
        UserLike Liking(int userId, int fileId);
        bool IsLiked(int userId, int fileId);
	}
}
