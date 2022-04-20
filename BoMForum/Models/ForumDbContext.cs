using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    TagID = 1,
                    TagText = "Atonement"
                },
                new Tag
                {
                    TagID = 2,
                    TagText = "Missionary Work"
                },
                new Tag
                {
                    TagID = 3,
                    TagText = "Godhead"
                },
                new Tag
                {
                    TagID = 4,
                    TagText = "Question"
                },
                new Tag
                {
                    TagID = 5,
                    TagText = "Testimony"
                },
                new Tag
                {
                    TagID = 6,
                    TagText = "Word of Wisdom"
                },
                new Tag
                {
                    TagID = 7,
                    TagText = "Law of Chastity"
                },
                new Tag
                {
                    TagID = 8,
                    TagText = "Tithing"
                },
                new Tag
                {
                    TagID = 9,
                    TagText = "Faith"
                },
                new Tag
                {
                    TagID = 10,
                    TagText = "Repentence"
                },
                new Tag
                {
                    TagID = 11,
                    TagText = "Baptism"
                },
                new Tag
                {
                    TagID = 12,
                    TagText = "Holy Ghost"
                },
                new Tag
                {
                    TagID = 13,
                    TagText = "Priesthood"
                },
                new Tag
                {
                    TagID = 14,
                    TagText = "Family"
                },
                new Tag
                {
                    TagID = 15,
                    TagText = "Covenants"
                },
                new Tag
                {
                    TagID = 16,
                    TagText = "Temples"
                },
                new Tag
                {
                    TagID = 17,
                    TagText = "Humility"
                },
                new Tag
                {
                    TagID = 18,
                    TagText = "Prophets"
                },
                new Tag
                {
                    TagID = 19,
                    TagText = "Hardships and Challenges"
                },
                new Tag
                {
                    TagID = 20,
                    TagText = "The Church"
                }

                );
            modelBuilder.Entity<UserPost>().HasData(
                new UserPost
                {
                    UserPostID = 1,
                    UserPostTitle = "Example Post",
                    UserPostText = "Lorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsum",
                    TagID = 1
                }

                );

        }


    }
}
