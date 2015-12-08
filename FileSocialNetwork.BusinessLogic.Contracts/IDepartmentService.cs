using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.BusinessLogic.Contracts
{
	public interface IDepartmentService
	{
		IEnumerable<Cathedra> GetAll();
		IEnumerable<Cathedra> GetByFacultyId(int id);
		IEnumerable<Group> GetBGroupsBySpecialityId(int id);
	}
}
