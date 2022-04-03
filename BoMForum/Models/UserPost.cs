using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models
{
    public class UserPost
    {
        public UserPost()
        {
            this.UserPostTags = new HashSet<UserPostTag>();
        }
        [Required]
        [Key]
        public int UserPostID { get; set; }
        [Required(ErrorMessage = "This textbox cannot be empty.")]
        public string UserPostText { get; set; }
        [Required(ErrorMessage = "Each post needs a title")]
        public string UserPostTitle { get; set; }
        public virtual ICollection<UserPostTag> UserPostTags { get; set; }

    }
}
