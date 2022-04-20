using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models
{
    public class EFForumRepository : IForumRepository
    {
        private ForumDbContext _context { get; set; }
        public EFForumRepository (ForumDbContext forumDbContext)
        {
            _context = forumDbContext;
        }
        public IQueryable<Comment> Comments => _context.Comments;

        public IQueryable<Tag> Tags => _context.Tags;

        public IQueryable<UserPost> UserPosts => _context.UserPosts.Include(x => x.Tag);
        

        public void SaveComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void SavePost(UserPost userPost)
        {

            _context.AttachRange(_context.Tags.Single(x => x.TagID == userPost.TagID));
            // Made need to add attach range
            if (userPost.UserPostID == 0)
            {
                _context.UserPosts.Add(userPost);
            }
            {
                _context.Update(userPost);
            }
            _context.SaveChanges();
        }

    }
}
