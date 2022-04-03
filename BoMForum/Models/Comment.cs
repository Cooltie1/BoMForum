using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models
{
    public class Comment
    {
        [Key]
        [Required]
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int Likes { get; set; } = 0;
        public int UserPostID { get; set; }
        public UserPost UserPost { get; set; }

    }
}
