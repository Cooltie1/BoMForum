using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models
{
    public class UserPostTag
    {
        public int UserPostID { get; set; }
        public UserPost UserPost { get; set; }
        public int TagID { get; set; }
        public Tag Tag { get; set; }
    }
}
