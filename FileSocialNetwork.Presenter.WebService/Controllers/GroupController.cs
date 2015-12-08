using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.Presenter.WebService.Models;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
	public class GroupController : ApiController
	{
		private IDepartmentService service;

		public GroupController(IDepartmentService service)
		{
			this.service = service;
		}

		[HttpGet]
		public IEnumerable<GroupViewModel> Get(int id)
		{
			IEnumerable<GroupViewModel> groups = service
				.GetBGroupsBySpecialityId(id)
				.Select(g => new GroupViewModel(g));

			return groups;
		}
	}
}
