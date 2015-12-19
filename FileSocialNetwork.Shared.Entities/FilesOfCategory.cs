using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class FilesOfCategory
	{
		public int CategoryId { get; set; }
		public string Category { get; set; }
		public List<FileInfo> Files { get; set; }

		public FilesOfCategory()
		{
			Files = new List<FileInfo>();
		}
	}
}
