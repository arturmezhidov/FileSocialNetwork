using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
	public class Cathedra
	{
		public int Id { get; set; }
		public string Title { get; set; }

		public int FacultyId { get; set; }

		public virtual Faculty Faculty { get; set; }
		public virtual ICollection<Subject> Subjects { get; set; }
		public virtual ICollection<Speciality> Specialities { get; set; }

		public Cathedra()
		{
			Subjects = new HashSet<Subject>();
			Specialities = new HashSet<Speciality>();
		}
	}
}
