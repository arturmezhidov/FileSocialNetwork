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
		public int? YearAmission { get; set; }
		public int? YearGraduation { get; set; }
		public string Login { get; set; }
		public string PasswordHash { get; set; }
		public string Email { get; set; }
		public bool? EmailConfirmed { get; set; }
		public string PhoneNumber { get; set; }

		public int UserRoleId { get; set; }
		public int GroupId { get; set; }

		public virtual UserRole UserRole { get; set; }
		public virtual Group Group { get; set; }
		public virtual ICollection<File> Files { get; set; }
		public virtual ICollection<Message> Messages { get; set; }
		public virtual ICollection<UserMessage> UserMessages { get; set; }

		public User()
		{
			Files = new HashSet<File>();
			Messages = new HashSet<Message>();
		}
	}
}
