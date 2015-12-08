using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.Presenter.WebService.Models
{
	public class FacultyViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public IEnumerable<DepartmentViewModel> Departments { get; set; }

		public FacultyViewModel()
		{
			Departments = new List<DepartmentViewModel>();
		}
		public FacultyViewModel(Faculty faculty) : this()
		{
			Id = faculty.Id;
			Title = faculty.Title;
		}
	}
}