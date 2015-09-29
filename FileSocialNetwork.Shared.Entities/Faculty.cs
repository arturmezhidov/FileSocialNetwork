using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class Faculty
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public ICollection<Cathedra> Cathedras { get; set; }

		public Faculty()
		{
			Cathedras = new HashSet<Cathedra>();
		}
	}
}
