using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendsForever_Api.Data;
using FriendsForever_Api.Security;
using FriendsForever_Library.Models;
using FriendsForever_Library.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FriendsForever_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServiceController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public ServiceController(AppDbContext dbContext, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("CheckMobileDuplicacyAsync")]
        public async Task<ActionResult<string>> CheckMobileDuplicacyAsync([FromBody] string mobileNumber)
        {
            string mobile = string.Empty;
            try
            {
                var result = await dbContext.Users.FirstOrDefaultAsync(f => f.PhoneNumber == mobileNumber);
                if (result != null)
                {
                    mobile = result.PhoneNumber;
                }

                if (string.IsNullOrEmpty(mobile))
                {
                    mobile = "NotFound";
                }
            }
            catch (Exception)
            {

                mobile = "NotFound";
            }
            return mobile;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("CheckEmailDuplicacyAsync")]
        public async Task<ActionResult<string>> CheckEmailDuplicacyAsync([FromBody] string emailAddress)
        {
            string email = string.Empty;
            try
            {
                var result = await dbContext.Users.FirstOrDefaultAsync(f => f.Email.ToLower() == emailAddress.ToLower());
                if (result != null)
                {
                    email = result.Email;
                }

                if (string.IsNullOrEmpty(email))
                {
                    email = "NotFound";
                }
            }
            catch (Exception)
            {

                email = "NotFound";
            }
            return email;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("CheckUsernameDuplicacyAsync")]
        public async Task<ActionResult<string>> CheckUsernameDuplicacyAsync([FromBody] string Username)
        {
            string username = string.Empty;
            try
            {
                var result = await dbContext.Users.FirstOrDefaultAsync(f => f.UserName.ToLower() == Username.ToLower());
                if (result != null)
                {
                    username = result.UserName;
                }

                if (string.IsNullOrEmpty(username))
                {
                    username = "NotFound";
                }
            }
            catch (Exception)
            {

                username = "NotFound";
            }
            return username;
        }

        [HttpGet]
        [Route("GetAllFriendsAsync")]
        public async Task<ActionResult<IEnumerable<ShowAllFriend>>> GetAllFriendsAsync(string userId)
        {
            var result = await dbContext.FriendsMaster
                .Where(w => w.UserIdRequest == userId && w.Status == "Accept")
                .Select(s => s.UserIdResponse).ToListAsync();
            List<ApplicationUser> users = new List<ApplicationUser>();
            foreach (var item in result)
            {
                var user = await dbContext.Users.FirstOrDefaultAsync(f => f.Id == item);
                users.Add(user);
            }
            List<ShowAllFriend> model = new List<ShowAllFriend>();
            foreach (var friend in users)
            {
                model.Add(new ShowAllFriend
                {
                    FriendFullName = friend.FullName,
                    ProfilePhotoPath = friend.ProfilePhotoPath
                });
            }
            return model;
        }

        [HttpGet]
        [Route("GetNewFriendsRequestAsync")]
        public async Task<ActionResult<IEnumerable<ShowFriendsReuqestData>>> GetNewFriendsRequestAsync(string userId)
        {
            var result = await dbContext.FriendsMaster
                .Where(w => w.UserIdResponse == userId && w.Status == "Pending")
                .Select(s => s.UserIdRequest).ToListAsync();
            List<ApplicationUser> users = new List<ApplicationUser>();
            foreach (var item in result)
            {
                var user = await dbContext.Users.FirstOrDefaultAsync(f => f.Id == item);
                users.Add(user);
            }
            List<ShowFriendsReuqestData> model = new List<ShowFriendsReuqestData>();
            foreach (var friend in users)
            {
                model.Add(new ShowFriendsReuqestData
                {
                    ProfilePhotoPath = friend.ProfilePhotoPath,
                    SenderFullName = friend.FullName
                });
            }
            return model;
        }

        [HttpPut]
        [Route("AcceptRejectRequestUpdateAsync")]
        public async Task<ActionResult<int>> AcceptRejectRequestUpdateAsync(Friends model)
        {
            var friend = await dbContext.FriendsMaster
                .Where(w => w.UserIdRequest == model.UserIdRequest && w.Status == "Pending")
                .FirstOrDefaultAsync();
            if (friend != null)
            {
                friend.Status = model.Status;
                friend.UserIdRequest = model.UserIdRequest;
                dbContext.FriendsMaster.Update(friend);
            }
            return await dbContext.SaveChangesAsync();
        }

        [HttpPost]
        [Route("InsertFriendsReuqestDataAsync")]
        public async Task<ActionResult<int>> InsertFriendsReuqestDataAsync(Friends friends)
        {
            dbContext.FriendsMaster.Add(friends);
            return await dbContext.SaveChangesAsync();
        }

        [HttpGet]
        [Route("FindByIdUserInterestAsync")]
        public async Task<ActionResult<IEnumerable<string>>> FindByIdUserInterestAsync([FromBody] string userId)
        {
            return await dbContext.UserInterestMaster
                .Where(w => w.UserId == userId)
                .Select(s => s.InterestName)
                .ToListAsync();
        }

        [HttpPost]
        [Route("InsertUserInterestAsync")]
        public async Task<ActionResult<int>> InsertUserInterestAsync([FromBody] UserInterest userInterest)
        {
            await dbContext.UserInterestMaster.AddAsync(userInterest);
            return await dbContext.SaveChangesAsync();
        }

        [HttpPost]
        [Route("CheckPostTableDataAsync")]
        public async Task<ActionResult<int>> CheckPostTableDataAsync([FromBody] string userId)
        {
            var resultCount = await dbContext.PostMaster.Where(w => w.PostedOwnerUserId == userId).CountAsync();
            return resultCount;
        }

        [HttpPost]
        [Route("GetFriendsListByUserIdAsync")]
        public async Task<ActionResult<IEnumerable<Friends>>> GetFriendsListByUserIdAsync([FromBody] string userId)
        {
            return await dbContext.FriendsMaster
                .Where(w => w.UserIdRequest == userId && w.Status.ToLower() == "accept").ToListAsync();
        }

        [HttpPost]
        [Route("FindPostByUserIdAsync")]
        public async Task<ActionResult<IEnumerable<Post>>> FindPostByUserIdAsync([FromBody] List<string> UserIds)
        {
            var result = await dbContext.PostMaster.Where(w => UserIds.Contains(w.PostedOwnerUserId))
                .OrderByDescending(o => o.PostedTimeStamp).ToListAsync();
            return result;
        }

        [HttpPost]
        [Route("FindPostImagesByPostIdAsync")]
        public async Task<ActionResult<IEnumerable<PostImages>>> FindPostImagesByPostIdAsync([FromBody] string postedId)
        {
            return await dbContext.PostImagesMaster.Where(w => w.PostedId == postedId).ToListAsync();
        }

        [HttpPost]
        [Route("CheckDuplicateLikesAsync")]
        public async Task<ActionResult<int>> CheckDuplicateLikesAsync([FromBody] DuplicateLikesViewModel model)
        {
            var result = await dbContext.LikesMaster.Where(w => w.LikeUserId == model.userId && w.PostedId == model.postId).CountAsync();
            return result;
        }

        [HttpPost]
        [Route("InsertPostLikesAsync")]
        public async Task<ActionResult<int>> InsertPostLikesAsync([FromBody] Likes model)
        {
            await dbContext.LikesMaster.AddAsync(model);
            return await dbContext.SaveChangesAsync();
        }

        [HttpPost]
        [Route("UpdatePostMasterLikesAsync")]
        public async Task<ActionResult<int>> UpdatePostMasterLikesAsync(string postId)
        {
            var post = await dbContext.PostMaster.FirstOrDefaultAsync(f => f.PostedId == postId);
            var likeCount = await dbContext.LikesMaster.Where(w => w.PostedId == postId).CountAsync();
            if (post != null)
            {
                post.LikesCount = likeCount;
                dbContext.Update(post).Property(p => p.Id).IsModified = false;
            }
            var result = await dbContext.SaveChangesAsync();
            return result;
        }

        [HttpPost]
        [Route("InsertNewPostAsync")]
        public async Task<ActionResult<int>> InsertNewPostAsync(Post post)
        {
            await dbContext.PostMaster.AddAsync(post);
            return await dbContext.SaveChangesAsync();
        }

        [HttpPost]
        [Route("InsertNewPostImagesAsync")]
        public async Task<ActionResult<int>> InsertNewPostImagesAsync(PostImages postImages)
        {
            await dbContext.PostImagesMaster.AddAsync(postImages);
            return await dbContext.SaveChangesAsync();
        }
    }
}