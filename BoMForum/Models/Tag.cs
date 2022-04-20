using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoMForum.Models
{
    public class Tag
    {

        [Key]
        [Required]
        public int TagID { get; set; }
        [Required]
        public string TagText { get; set; }
        
    }
}
