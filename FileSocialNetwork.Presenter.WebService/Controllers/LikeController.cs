using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using FileSocialNetwork.Presenter.WebService.Models;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
    [Authorize]
    public class LikeController : ApiController
    {
        private ApplicationUserManager _userManager;

        protected string UserId
        {
            get
            {
                return User.Identity.GetUserId();
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private readonly IFileService service;

        public LikeController(IFileService service)
        {
            this.service = service;
        }

        // POST api/like
        public async Task<LikeInfoViewModel> Post(int fileId)
        {
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());

            UserLike like = service.Liking(user.ProfileUserId, fileId);

            LikeInfoViewModel likeViewModel = new LikeInfoViewModel(like, true);

            return likeViewModel;
        }
    }
}
