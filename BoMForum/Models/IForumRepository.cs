using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models
{
    public interface IForumRepository
    {
        public IQueryable<Comment> Comments { get; }
        public IQueryable<Tag> Tags { get; }
        public IQueryable<UserPost> UserPosts { get; }
        public IQueryable<UserPostTag> UserPostTags { get; }
        public void SavePost(UserPost userPost);
        public void SaveComment(Comment comment);
    }
}
