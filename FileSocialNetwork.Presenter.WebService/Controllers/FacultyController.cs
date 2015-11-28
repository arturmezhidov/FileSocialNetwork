using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.Presenter.WebService.Models;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
	public class FacultyController : ApiController
	{
		private IFacultyService service;

		public FacultyController(IFacultyService service)
		{
			this.service = service;
		}

		// GET api/values
		public IEnumerable<FacultyViewModel> Get()
		{
			IEnumerable<FacultyViewModel> vm = service
												.GetFaculties()
												.Select(faculty => new FacultyViewModel(faculty));

			return vm;
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
