using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models.ViewModels
{
    public class DetailsPage
    {
        public UserPost UserPost { get; set; }
        public IQueryable<Comment> Comments { get; set; }

        public DetailsPage(UserPost userPost, IQueryable<Comment> comments)
        {
            UserPost = userPost;
            Comments = comments;
        }
    }
}
