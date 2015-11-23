using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public int GroupId { get; set; }

		public virtual Group Group { get; set; }
		public virtual ICollection<File> Files { get; set; }
		public virtual ICollection<Like> Likes { get; set; }
		public virtual ICollection<Message> Messages { get; set; }
		public virtual ICollection<UserMessage> UserMessages { get; set; }

		public User()
		{
			Files = new HashSet<File>();
			Likes = new HashSet<Like>();
			Messages = new HashSet<Message>();
			UserMessages = new HashSet<UserMessage>();
		}
	}
}
