using FriendsForever_Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FriendsForever_Library.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string MobileNo { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public DateTime? Dob { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
