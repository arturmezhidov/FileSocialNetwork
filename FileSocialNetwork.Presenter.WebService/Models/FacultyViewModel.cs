using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.Presenter.WebService.Models
{
	public class FacultyViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public FacultyViewModel() { }
		public FacultyViewModel(Faculty faculty)
		{
			Id = faculty.Id;
			Title = faculty.Title;
		}
	}
}