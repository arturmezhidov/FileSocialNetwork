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
	public class SubjectController : ApiController
	{
		private ISubjectService service;

		public SubjectController(ISubjectService service)
		{
			this.service = service;
		}

		[HttpGet]
		public IEnumerable<SubjectFiles> GetSubjectFiles(int id)
		{
			IEnumerable<SubjectFiles> subjectFiles = service.GetByDepartmentId(id);

			foreach (SubjectFiles subjectFile in subjectFiles)
			{
				foreach (FilesOfCategory category in subjectFile.Categories)
				{
					foreach (FileInfo fileInfo in category.Files)
					{
						fileInfo.Url = String.Format("http://{0}/Files/{1}", Request.RequestUri.Authority, fileInfo.Name);
					}
				}
			}

			return subjectFiles;
		}
	}
}
