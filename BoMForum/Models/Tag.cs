using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models
{
    public class Tag
    {
        public Tag()
        {
            this.UserPostTags = new HashSet<UserPostTag>();
        }
        [Key]
        [Required]
        public int TagID { get; set; }
        [Required]
        public string TagText { get; set; }
        public HashSet<UserPostTag> UserPostTags { get; set; }
    }
}
