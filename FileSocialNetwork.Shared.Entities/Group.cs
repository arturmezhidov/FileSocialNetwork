using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class Group
	{
		public int Id { get; set; }
		public string Number { get; set; }

		public int SpecialityId { get; set; }

		public virtual Speciality Speciality { get; set; }
		public virtual ICollection<User> Users { get; set; }

		public Group()
		{
			Users = new HashSet<User>();
		}
	}
}
