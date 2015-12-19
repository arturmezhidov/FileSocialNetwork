using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.Presenter.WebService.Models;
using FileSocialNetwork.Shared.Entities;
using System.Web.Http.Cors;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
    [EnableCors("*", "*", "*")]
	public class DepartmentController : ApiController
	{
		private IDepartmentService service;

		public DepartmentController(IDepartmentService service)
		{
			this.service = service;
		}

		// GET: api/Department
		[HttpGet]
		public IEnumerable<DepartmentViewModel> Get()
		{
			IEnumerable<DepartmentViewModel> vmList = service
														.GetAll()
														.Select(ToDepartmentViewModel);

			return vmList;
		}

		// GET: api/Department/id
		[HttpGet]
		public IEnumerable<DepartmentViewModel> Get(int id)
		{
			IEnumerable<DepartmentViewModel> vmList = service
											.GetByFacultyId(id)
											.Select(ToDepartmentViewModel);
		
			return vmList;
		}

		protected DepartmentViewModel ToDepartmentViewModel(Cathedra department)
		{
			DepartmentViewModel vm = new DepartmentViewModel(department);
			vm.Specialities = department.Specialities.Select(s => new SpecialityViewModel(s)).ToList();
			return vm;
		}
	}
}
