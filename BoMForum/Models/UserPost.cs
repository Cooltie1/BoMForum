using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models
{
    public class UserPost
    {
       
        [Required]
        [Key]
        public int UserPostID { get; set; }
        [Required(ErrorMessage = "This textbox cannot be empty.")]
        public string UserPostText { get; set; }
        [Required(ErrorMessage = "Each post needs a title")]
        public string UserPostTitle { get; set; }
        public Tag Tag { get; set; }
        public int TagID { get; set; }

    }
}
