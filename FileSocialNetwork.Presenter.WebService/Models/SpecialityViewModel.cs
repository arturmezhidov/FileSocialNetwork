using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.Presenter.WebService.Models
{
	public class SpecialityViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Number { get; set; }

		public SpecialityViewModel() { }
		public SpecialityViewModel(Speciality speciality)
		{
			Id = speciality.Id;
			Title = speciality.Title;
			Number = speciality.Number;
		}
	}
}