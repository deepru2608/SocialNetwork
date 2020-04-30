using System;
using System.Collections.Generic;
using System.Text;

namespace FriendsForever_Library.Models
{
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public string Status { get; set; }
    }
}
