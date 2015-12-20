using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using FileSocialNetwork.Presenter.WebService.Models;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
    public class BaseController : ApiController
    {
        private ApplicationUser user;
        private ApplicationUserManager userManager;

        protected ApplicationUser ApplicationUser
        {
            get
            {
                if (user == null)
                {
                    string id = User.Identity.GetUserId();
                    user = UserManager.FindById(id);
                }

                return user;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                userManager = value;
            }
        }
    }
}
