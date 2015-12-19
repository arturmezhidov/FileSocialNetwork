using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.DataAccess.Contracts;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.BusinessLogic.BusinessComponents
{
	public class FileService : IFileService
	{
		private IUnitOfWork context;

		public FileService(IUnitOfWork unitOfWork)
		{
			context = unitOfWork;
		}

		public IEnumerable<FileCategory> GetAllCategory()
		{
			return context.FileCategories.GetAll();
		}

        public File CreateFile(string name, string description, int userId, int categoryId, int subjectId)
        {
            File file = new File
            {
                Name = name,
                Description = description,
                DateOfCreate = DateTime.Now,
                UserId = userId,
                FileCategoryId = categoryId,
                SubjectId = subjectId
            };

            context.Files.Create(file);
            context.Save();

            return file;
        }

        public UserLike Liking(int userId, int fileId)
        {
            File file = context.Files.GetById(fileId);

            if (file == null)
            {
                return null;
            }

            Like like = file.Likes.FirstOrDefault(item => item.UserId == userId);

            if (like == null)
            {
                context.Likes.Create(new Like
                {
                    UserId = userId,
                    FileId = fileId
                });
            }
            else
            {
                context.Likes.Delete(like.Id);
            }

            context.Save();

            UserLike userLike = new UserLike
            {
                Liked = (like == null),
                LikesCount = file.Likes.Count
            };

            return userLike;
        }
	}
}
