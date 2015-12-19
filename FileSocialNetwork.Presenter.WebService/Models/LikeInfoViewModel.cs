using FileSocialNetwork.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileSocialNetwork.Presenter.WebService.Models
{
    public class LikeInfoViewModel
    {
        public int LikesCount { get; set; }
        public bool Liked { get; set; }
        public bool Success { get; set; }

        public LikeInfoViewModel() { }

        public LikeInfoViewModel(UserLike like)
        {
            LikesCount = like.LikesCount;
            Liked = like.Liked;
        }

        public LikeInfoViewModel(UserLike like, bool isSuccess)
            : this(like)
        {
            Success = isSuccess;
        }
    }
}