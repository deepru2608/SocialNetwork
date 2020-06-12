using FriendsForever_App.Auth;
using FriendsForever_Library.Models;
using FriendsForever_Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FriendsForever_App.Services
{
    public interface IUserService
    {
        Task<IEnumerable<Country>> GetCountryListAsync();

        Task<UserToken> RegisterNewUserAsync(RegisterViewModel model);

        Task<UserToken> LoginUserAsync(LoginViewModel model);

        Task<HttpResponseMessage> CreateRoleAsync(string roleName);

        Task<ApplicationUser> GetUserDetailsAsync();

        Task<ApplicationUser> GetUserByNameAsync(string Name);

        Task<string> UpdateUserProfileAsync(EditProfileViewModel model);
    }
}
