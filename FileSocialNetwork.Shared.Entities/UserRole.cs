using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class UserRole
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<User> Users { get; set; }

		public UserRole()
		{
			Users = new HashSet<User>();
		}
	}
}
