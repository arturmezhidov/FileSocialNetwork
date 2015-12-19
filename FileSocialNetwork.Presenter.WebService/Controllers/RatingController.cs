using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.Shared.Entities;
using System.Web.Http.Cors;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
    [EnableCors("*", "*", "*")]
    [Authorize(Roles="admin")]
	public class RatingController : ApiController
	{
		private IRatingService service;
        
		public RatingController(IRatingService service)
		{
			this.service = service;
		}

		// GET: api/Rating
		[HttpGet]
		public TotalRating Get()
		{
			return service.GetTotalRating();
		}
	}
}
