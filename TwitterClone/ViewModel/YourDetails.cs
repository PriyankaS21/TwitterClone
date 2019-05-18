﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwitterClone.ViewModel
{
    public class YourDetails
    {
        [Required]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Fullname is required")]
        [StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 3)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }
    }
}