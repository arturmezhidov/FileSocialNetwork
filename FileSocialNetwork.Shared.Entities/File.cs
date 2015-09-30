using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class File
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime DateOfCreate { get; set; }

		public int? UserId { get; set; }
		public int SubjectId { get; set; }

		public virtual User User { get; set; }
		public virtual Subject Subject { get; set; }
	}
}
