using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class SubjectFiles
	{
		public int SubjectId { get; set; }
		public string SubjectTitle { get; set; }
		public int FilesCount { get; set; }
		public List<FilesOfCategory> Categories { get; set; }

		public SubjectFiles()
		{
			Categories = new List<FilesOfCategory>();
		}
	}
}
