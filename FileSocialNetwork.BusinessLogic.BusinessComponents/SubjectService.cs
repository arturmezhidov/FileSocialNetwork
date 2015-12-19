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
	public class SubjectService : ISubjectService
	{
		private IUnitOfWork uow;

		public SubjectService(IUnitOfWork uow)
		{
			this.uow = uow;
		}

		public IEnumerable<SubjectFiles> GetByDepartmentId(int id)
		{
			Cathedra department = uow.Cathedras.GetById(id);

			if (department == null)
			{
				return new List<SubjectFiles>();
			}

			List<SubjectFiles> subjectFiles = new List<SubjectFiles>();

			foreach (Subject subject in department.Subjects)
			{
				SubjectFiles sf = new SubjectFiles()
				{
					SubjectId = subject.Id,
					SubjectTitle = subject.Title,
					FilesCount = subject.Files.Count
				};

				foreach (IGrouping<FileCategory, File> files in subject.Files.GroupBy(f => f.FileCategory))
				{
					FilesOfCategory foc = new FilesOfCategory()
					{
						Category = files.Key.Name,
						CategoryId = files.Key.Id
					};

					foreach (File file in files)
					{
						FileInfo fileInfo = new FileInfo()
						{
							Id = file.Id,
							Name = file.Name,
							Description = file.Description,
							DateOfCreate = file.DateOfCreate,
							UserId = file.User.Id,
							UserName = String.Format("{0} {1}", file.User.FirstName, file.User.LastName),
							Likes = file.Likes.Count
						};

						foc.Files.Add(fileInfo);
					}

					sf.Categories.Add(foc);
				}
				 
				subjectFiles.Add(sf);
			}

			return subjectFiles;
		}
	}
}
