﻿using FriendsForever_Library.Models;
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
    public class CenterService : ICenterService
    {
        private static readonly string TokenKey = "access_token";
        private readonly HttpClient httpClient;
        private readonly ProtectedLocalStorage protectedLocalStorage;

        public CenterService(HttpClient httpClient, ProtectedLocalStorage protectedLocalStorage)
        {
            this.httpClient = httpClient;
            this.protectedLocalStorage = protectedLocalStorage;
        }

        public async Task<string> CheckMobileDuplicacyAsync(string mobileNumber)
        {
            string serializedCode = JsonConvert.SerializeObject(mobileNumber);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "CheckMobileDuplicacyAsync")
            {
                Content = new StringContent(serializedCode)
            };
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.SendAsync(requestMessage);
            var mobile = await response.Content.ReadAsStringAsync();
            return mobile;
        }

        public async Task<string> CheckEmailDuplicacyAsync(string emailAddress)
        {
            string serializedCode = JsonConvert.SerializeObject(emailAddress);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "CheckEmailDuplicacyAsync")
            {
                Content = new StringContent(serializedCode)
            };
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.SendAsync(requestMessage);
            var mobile = await response.Content.ReadAsStringAsync();
            return mobile;
        }

        public async Task<string> CheckUsernameDuplicacyAsync(string Username)
        {
            string serializedCode = JsonConvert.SerializeObject(Username);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "CheckUsernameDuplicacyAsync")
            {
                Content = new StringContent(serializedCode)
            };
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await httpClient.SendAsync(requestMessage);
            var mobile = await response.Content.ReadAsStringAsync();
            return mobile;
        }

        public async Task<IEnumerable<ShowAllFriend>> GetAllFriendsAsync(string userId)
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(userId);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "GetAllFriendsAsync");
            requestMessage.Content = new StringContent(serializedData);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            IEnumerable<ShowAllFriend> friendsList = new List<ShowAllFriend>();
            if (response.IsSuccessStatusCode)
            {
                friendsList = JsonConvert.DeserializeObject<IEnumerable<ShowAllFriend>>(await response.Content.ReadAsStringAsync());
                return friendsList;
            }

            return friendsList;
        }

        public async Task<IEnumerable<ShowFriendsReuqestData>> GetNewFriendsRequestAsync(string userId)
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(userId);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "GetNewFriendsRequestAsync");
            requestMessage.Content = new StringContent(serializedData);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            IEnumerable<ShowFriendsReuqestData> friendsRequestList = new List<ShowFriendsReuqestData>();
            if (response.IsSuccessStatusCode)
            {
                friendsRequestList = JsonConvert.DeserializeObject<IEnumerable<ShowFriendsReuqestData>>(await response.Content.ReadAsStringAsync());
                return friendsRequestList;
            }

            return friendsRequestList;
        }

        public async Task<int> AcceptRejectRequestUpdateAsync(Friends model)
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(model);
            var requestMessage = new HttpRequestMessage(HttpMethod.Put, "AcceptRejectRequestUpdateAsync");
            requestMessage.Content = new StringContent(serializedData);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            int result = 0;
            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<int>(await response.Content.ReadAsStringAsync());
                return result;
            }

            return result;
        }

        public async Task<int> InsertFriendsReuqestDataAsync(Friends model)
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(model);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "InsertFriendsReuqestDataAsync");
            requestMessage.Content = new StringContent(serializedData);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            int result = 0;
            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<int>(await response.Content.ReadAsStringAsync());
                return result;
            }

            return result;
        }

        public async Task<IEnumerable<string>> FindByIdUserInterestAsync(string userId)
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(userId);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "FindByIdUserInterestAsync");
            requestMessage.Content = new StringContent(serializedData);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            IEnumerable<string> userInterests = new List<string>();
            if (response.IsSuccessStatusCode)
            {
                userInterests = JsonConvert.DeserializeObject<IEnumerable<string>>(await response.Content.ReadAsStringAsync());
                return userInterests;
            }

            return userInterests;
        }

        public async Task<int> InsertUserInterestAsync(UserInterest userInterest)
        {
            string token = await protectedLocalStorage.GetAsync<string>(TokenKey);
            string serializedData = JsonConvert.SerializeObject(userInterest);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "InsertUserInterestAsync");
            requestMessage.Content = new StringContent(serializedData);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            var response = await httpClient.SendAsync(requestMessage);
            int result = 0;
            if (response.IsSuccessStatusCode)
            {
                result = JsonConvert.DeserializeObject<int>(await response.Content.ReadAsStringAsync());
                return result;
            }

            return result;
        }
    }
}
