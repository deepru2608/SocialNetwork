using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsForever_Library.ViewModels
{
    public class EditProfileViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10), MinLength(10)]
        [Phone]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        public string userId { get; set; }
    }
}
