using System;
using System.Collections.Generic;
using System.Text;

namespace FriendsForever_Library.Models
{
    public class UserInfo
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
