using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FileSocialNetwork.BusinessLogic.Contracts;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
	public class HomeController : Controller
	{
		private IFacultyService service;

		public HomeController(IFacultyService service)
		{
			this.service = service;
		}

		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			//var t = service.Create("efwfw");

			return View();
		}
	}
}
