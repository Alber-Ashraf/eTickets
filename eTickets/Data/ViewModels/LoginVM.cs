﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
