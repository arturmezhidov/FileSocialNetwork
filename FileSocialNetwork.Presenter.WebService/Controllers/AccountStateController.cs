using FileSocialNetwork.Presenter.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
    public class AccountStateController : ApiController
    {
        [HttpGet]
        public ConfirmLoginViewModel ConfirmLogin()
        {
            return new ConfirmLoginViewModel
            {
                IsAuthorize = User.Identity.IsAuthenticated,
                IsAdmin = User.IsInRole("admin")
            };
        }
    }
}
