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
		public string OfficialUrl { get; set; }

		public virtual ICollection<Cathedra> Cathedras { get; set; }

		public Faculty()
		{
			Cathedras = new HashSet<Cathedra>();
		}
	}
}
