using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class FileInfo
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime DateOfCreate { get; set; }
		public int UserId { get; set; }
		public string UserName { get; set; }
		public int Likes { get; set; }
        public bool Liked { get; set; }
		public string Url { get; set; }
	}
}
