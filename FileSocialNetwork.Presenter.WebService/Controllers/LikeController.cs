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
    public class LikeController : BaseController
    {
        private readonly IFileService service;

        public LikeController(IFileService service)
        {
            this.service = service;
        }

        // POST api/like
        [HttpPost]
        public LikeInfoViewModel Post([FromBody]LikeViewModel model)
        {
            UserLike like = service.Liking(ApplicationUser.ProfileUserId, model.FileId);

            LikeInfoViewModel likeViewModel = new LikeInfoViewModel(like, true);

            return likeViewModel;
        }
    }
}
