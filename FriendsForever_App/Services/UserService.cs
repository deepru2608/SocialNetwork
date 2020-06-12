using FriendsForever_App.Auth;
using FriendsForever_Library.Models;
using FriendsForever_Library.ViewModels;
using Microsoft.AspNetCore.ProtectedBrowserStorage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FriendsForever_App.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;
        private readonly ProtectedLocalStorage protectedLocalStorage;
        private static readonly string TokenKey = "access_token";

        public UserService(HttpClient httpClient, ProtectedLocalStorage protectedLocalStorage)
        {
            this.httpClient = httpClient;
            this.protectedLocalStorage = protectedLocalStorage;
        }

        public async Task<HttpResponseMessage> CreateRoleAsync(string roleName)
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(roleName);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "CreateRoleAsync")
            {
                Content = new StringContent(serializedData)
            };
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            return response;
        }

        public async Task<IEnumerable<Country>> GetCountryListAsync()
        {
            var response = await httpClient.GetAsync("GetCountryListAsync");
            var countryList = JsonConvert.DeserializeObject<List<Country>>(await response.Content.ReadAsStringAsync());
            return countryList;
        }

        public async Task<UserToken> LoginUserAsync(LoginViewModel model)
        {
            string serializedUser = JsonConvert.SerializeObject(model);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "LoginUserAsync")
            {
                Content = new StringContent(serializedUser)
            };
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.SendAsync(requestMessage);
            var responseBody = await response.Content.ReadAsStringAsync();
            var userToken = JsonConvert.DeserializeObject<UserToken>(responseBody);
            return userToken;
        }

        public async Task<UserToken> RegisterNewUserAsync(RegisterViewModel model)
        {
            string serializedUser = JsonConvert.SerializeObject(model);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "CreateUserAsync")
            {
                Content = new StringContent(serializedUser)
            };
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.SendAsync(requestMessage);
            var responseBody = await response.Content.ReadAsStringAsync();
            var userToken = JsonConvert.DeserializeObject<UserToken>(responseBody);
            return userToken;
        }

        public async Task<ApplicationUser> GetUserDetailsAsync()
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(token);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "GetUserDetailsAsync");
            requestMessage.Content = new StringContent(serializedData);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            if (response.IsSuccessStatusCode)
            {
                var user = JsonConvert.DeserializeObject<ApplicationUser>(await response.Content.ReadAsStringAsync());
                return user;
            }

            ApplicationUser otherUser = null;
            return otherUser;
        }

        public async Task<ApplicationUser> GetUserByNameAsync(string Name)
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(Name);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "GetUserByNameAsync");
            requestMessage.Content = new StringContent(serializedData);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            if (response.IsSuccessStatusCode)
            {
                var user = JsonConvert.DeserializeObject<ApplicationUser>(await response.Content.ReadAsStringAsync());
                return user;
            }

            ApplicationUser otherUser = null;
            return otherUser;
        }

        public async Task<string> UpdateUserProfileAsync(EditProfileViewModel model)
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(model);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "UpdateUserProfileAsync");
            requestMessage.Content = new StringContent(serializedData);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync());
                return result;
            }

            return "Failure";
        }
    }
}
