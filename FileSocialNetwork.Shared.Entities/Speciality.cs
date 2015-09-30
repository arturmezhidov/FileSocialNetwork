using System.Collections.Generic;

namespace FileSocialNetwork.Shared.Entities
{
	public class Speciality
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Number { get; set; }

		public int CathedraId { get; set; }

		public virtual Cathedra Cathedra { get; set; }
		public virtual ICollection<Group> Groups { get; set; }

		public Speciality()
		{
			Groups = new HashSet<Group>();
		}
	}
}
