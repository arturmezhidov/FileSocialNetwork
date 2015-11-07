using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileSocialNetwork.Shared.Entities
{
	public class UserMessage
	{
		[Key]
		[ForeignKey("Message")]
		public int Id { get; set; }

		public int UserId { get; set; }

		public virtual User User { get; set; }
		public virtual Message Message { get; set; }
	}
}
