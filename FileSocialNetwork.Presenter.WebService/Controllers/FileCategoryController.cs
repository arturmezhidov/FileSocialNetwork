using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.Presenter.WebService.Models;
using System.Web.Http.Cors;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
    [EnableCors("*", "*", "*")]
    public class FileCategoryController : ApiController
    {
		private IFileService service;

		public FileCategoryController(IFileService service)
		{
			this.service = service;
		}

		public IEnumerable<FileCategoryViewModel> Get()
		{
			return service.GetAllCategory().Select(i => new FileCategoryViewModel(i));
		}
    }
}
