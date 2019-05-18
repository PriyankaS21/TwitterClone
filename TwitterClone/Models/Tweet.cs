using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwitterClone.Models
{
    public class Tweet
    {
        [Key]
        [Required]
        public int Tweet_id { get; set; }
        public virtual Person user { get; set; }
        [Required]
        public int user_id { get; set; }
        [Required]
        [StringLength(140, ErrorMessage = "Must be between 3O and 60 characters", MinimumLength = 80)]
        public string Message { get; set; }
        [Required]
        public DateTime Created { get; set; }

    }
}