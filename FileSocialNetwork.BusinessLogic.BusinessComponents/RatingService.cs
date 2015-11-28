using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.BusinessLogic.Contracts;
using FileSocialNetwork.DataAccess.Contracts;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.BusinessLogic.BusinessComponents
{
	public class RatingService : IRatingService
	{
		private IUnitOfWork context;

		public RatingService(IUnitOfWork unitOfWork)
		{
			context = unitOfWork;
		}

		public TotalRating GetTotalRating()
		{
			TotalRating rating = new TotalRating()
			{
				FilesCount = context.Files.GetAll().Count(),
				SubjectsCount = context.Subjects.GetAll().Count(),
				UsersCount = context.Users.GetAll().Count()
			};

			return rating;
		}
	}
}
