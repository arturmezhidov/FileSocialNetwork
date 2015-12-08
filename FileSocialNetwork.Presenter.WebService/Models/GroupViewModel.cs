using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.Presenter.WebService.Models
{
	public class GroupViewModel
	{
		public int Id { get; set; }
		public string Number { get; set; }
		public int BeginYear { get; set; }
		public int EndYear { get; set; }
		public int SpecialityId { get; set; }

		public GroupViewModel() { }
		public GroupViewModel(Group group)
		{
			Id = group.Id;
			Number = group.Number;
			BeginYear = group.BeginYear;
			EndYear = group.EndYear;
			SpecialityId = group.SpecialityId;
		}
	}
}