using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class Subject
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public int CathedraId { get; set; }

		public virtual Cathedra Cathedra { get; set; }
		public virtual ICollection<File> Files { get; set; }

		public Subject()
		{
			Files = new HashSet<File>();
		}
	}
}
