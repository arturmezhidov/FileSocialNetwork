using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSocialNetwork.Shared.Entities
{
    public class UserLike
    {
        public int LikesCount { get; set; }
        public bool Liked { get; set; }
    }
}
