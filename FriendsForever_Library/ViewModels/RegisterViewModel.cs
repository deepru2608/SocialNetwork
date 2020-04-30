using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FriendsForever_Library.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Display(Name = "Sponsor Code")]
        public string SponsorCode { get; set; }

        [Display(Name = "Sponsor Name")]
        public string SponsorName { get; set; }

        [Required]
        public string State { get; set; }

        public string District { get; set; }
        public string Pincode { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Display(Name = "Mobile Number")]
        [Phone]
        [MaxLength(10), MinLength(10)]
        public string Mobile { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
