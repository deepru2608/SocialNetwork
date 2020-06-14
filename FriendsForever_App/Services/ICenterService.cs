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

        Task<int> CheckPostTableDataAsync(string userId);

        Task<IEnumerable<Friends>> GetFriendsListByUserIdAsync(string userId);

        Task<IEnumerable<Post>> FindPostByUserIdAsync(List<string> UserIds);

        Task<IEnumerable<PostImages>> FindPostImagesByPostIdAsync(string postedId);

        Task<int> CheckDuplicateLikesAsync(DuplicateLikesViewModel model);

        Task<int> InsertPostLikesAsync(Likes model);

        Task<int> UpdatePostMasterLikesAsync(string postId);

        Task<int> InsertNewPostAsync(Post post);

        Task<int> InsertNewPostImagesAsync(PostImages postImages);
    }
}
