﻿using System;
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
        public async Task<ActionResult<IEnumerable<string>>> FindByIdUserInterestAsync(string userId)
        {
            return await dbContext.UserInterestMaster
                .Where(w => w.UserId == userId)
                .Select(s => s.InterestName)
                .ToListAsync();
        }

        [HttpPost]
        [Route("InsertUserInterestAsync")]
        public async Task<ActionResult<int>> InsertUserInterestAsync(UserInterest userInterest)
        {
            await dbContext.UserInterestMaster.AddAsync(userInterest);
            return await dbContext.SaveChangesAsync();
        }
    }
}