﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsForever_App.Auth
{
    public interface ILoginService
    {
        Task Login(string token);
        Task Logout();
    }
}
