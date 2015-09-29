using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class Cathedra
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public int FacultyId { get; set; }

		public Faculty Faculty { get; set; }
	}
}
