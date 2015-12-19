using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using FileSocialNetwork.Presenter.WebService.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.Presenter.WebService.Providers;

namespace FileSocialNetwork.Presenter.WebService.Controllers
{
    public class FileController : ApiController
    {
        private IFileService service;

        protected string UserId
        {
            get
            {
                return User.Identity.GetUserId();
            }
        }

        public FileController(IFileService service)
        {
            this.service = service;
        }

        [HttpPost]
        [EnableCors("*", "*", "*")]
        public async Task<HttpResponseMessage> Upload()
        {
            if (!Request.Content.IsMimeMultipartContent())
            {
                this.Request.CreateResponse(HttpStatusCode.UnsupportedMediaType);
            }

            var provider = GetMultipartProvider();

            try
            {
                await Request.Content.ReadAsMultipartAsync(provider);

                UploadDataModel uploadData = GetFormData<UploadDataModel>(provider);
                int userId = 1;

                if (uploadData != null && uploadData.CategoryId > 0 && uploadData.SubjectId > 0 && userId > 0)
                {
                    service.CreateFile
                    (
                        provider.NewName,
                        provider.OldName,
                        userId,
                        uploadData.CategoryId,
                        uploadData.SubjectId
                    );
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        private UploadMultipartFormDataStreamProvider GetMultipartProvider()
        {
            string root = HttpContext.Current.Server.MapPath("~/Files/");
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            return new UploadMultipartFormDataStreamProvider(root);
        }
        private T GetFormData<T>(MultipartFormDataStreamProvider result) where T : class
        {
            if (result.FormData.HasKeys())
            {
                var json = "{" + result.FormData.ToString().Replace('&', ',').Replace('=', ':') + "}";

                if (!String.IsNullOrEmpty(json))
                    return JsonConvert.DeserializeObject<T>(json);
            }

            return null;
        }
        protected int GetUserId()
        {
            var user = ApplicationDbContext.Create().Users.Find(UserId);
            return user.ProfileUserId;
        }
    }
}
