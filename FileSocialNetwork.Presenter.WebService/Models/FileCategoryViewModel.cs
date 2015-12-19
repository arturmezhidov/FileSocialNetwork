using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.Presenter.WebService.Models
{
	public class FileCategoryViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public FileCategoryViewModel() { }
		public FileCategoryViewModel(FileCategory category)
		{
			Id = category.Id;
			Name = category.Name;
		}
	}
}