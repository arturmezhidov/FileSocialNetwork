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
	public class DepartmentService : IDepartmentService
	{
		private IUnitOfWork uow;

		public DepartmentService(IUnitOfWork uow)
		{
			this.uow = uow;
		}

		public IEnumerable<Cathedra> GetAll()
		{
			return uow.Cathedras.GetAll();
		}

		public IEnumerable<Cathedra> GetByFacultyId(int id)
		{
			Faculty faculty = uow.Faculties.GetById(id);

			if (faculty != null)
			{
				return faculty.Cathedras;
			}

			return new List<Cathedra>();
		}
	}
}
