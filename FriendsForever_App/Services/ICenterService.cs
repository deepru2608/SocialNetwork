using FriendsForever_Library.Models;
using FriendsForever_Library.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsForever_App.Services
{
    public interface ICenterService
    {
        Task<string> CheckMobileDuplicacyAsync(string mobileNumber);

        Task<string> CheckEmailDuplicacyAsync(string emailAddress);

        Task<string> CheckUsernameDuplicacyAsync(string Username);

        Task<IEnumerable<ShowAllFriend>> GetAllFriendsAsync(string userId);

        Task<IEnumerable<ShowFriendsReuqestData>> GetNewFriendsRequestAsync(string userId);

        Task<int> AcceptRejectRequestUpdateAsync(Friends model);

        Task<int> InsertFriendsReuqestDataAsync(Friends model);

        Task<IEnumerable<string>> FindByIdUserInterestAsync(string userId);

        Task<int> InsertUserInterestAsync(UserInterest userInterest);
    }
}
