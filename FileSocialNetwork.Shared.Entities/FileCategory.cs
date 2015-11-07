using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class FileCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<File> Files { get; set; }

		public FileCategory()
		{
			Files = new HashSet<File>();
		}
	}
}
