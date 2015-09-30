using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class Message
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public DateTime DateOfCreate { get; set; }

		public int UserId { get; set; }

		public virtual User User { get; set; }
		public virtual UserMessage UserMessage { get; set; }
	}
}
