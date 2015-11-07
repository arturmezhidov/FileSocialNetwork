using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class Like
	{
		public int Id { get; set; }
		public int? UserId { get; set; }
		public int FileId { get; set; }

		public virtual User User { get; set; }
		public virtual File File { get; set; }
	}
}
