using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.Presenter.WebService.Models
{
	public class DepartmentViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int FacultyId { get; set; }
		public List<SpecialityViewModel> Specialities { get; set; }

		public DepartmentViewModel()
		{
			Specialities = new List<SpecialityViewModel>();
		}
		public DepartmentViewModel(Cathedra deparmnet) : this()
		{
			Id = deparmnet.Id;
			Title = deparmnet.Title;
			FacultyId = deparmnet.FacultyId;
		}
	}
}