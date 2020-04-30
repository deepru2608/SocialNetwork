using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FriendsForever_Library.ViewModels
{
    public class EditRoleData
    {
        public string RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
