using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwitterClone.Models
{
    public class Follow
    {
        [Required]
        public int Following_id { get; set; }
        public virtual Person user { get; set; }
        [Required]
        public int user_Id { get; set; }
    }
}
