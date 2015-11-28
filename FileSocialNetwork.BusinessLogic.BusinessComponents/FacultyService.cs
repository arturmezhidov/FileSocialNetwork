using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.DataAccess.Contracts;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.BusinessLogic.BusinessComponents
{
	public class FacultyService : IFacultyService
	{
		private IUnitOfWork context;

		public FacultyService(IUnitOfWork unitOfWork)
		{
			context = unitOfWork;
		}

		public IEnumerable<Faculty> GetFaculties()
		{
			return context.Faculties.GetAll();
		}

		public Faculty Create(string title)
		{
			Faculty faculty = new Faculty
			{
				Title = title
			};

			context.Faculties.Create(faculty);
			context.Save();

			return faculty;
		}
	}
}
