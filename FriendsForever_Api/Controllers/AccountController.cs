using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using FriendsForever_Api.Data;
using FriendsForever_Api.Security;
using FriendsForever_Library.Models;
using FriendsForever_Library.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace FriendsForever_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SupportSecurity supportSecurity;
        private readonly IHttpContextAccessor httpContextAccessor;

        public AccountController(AppDbContext dbContext, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager,
            SupportSecurity supportSecurity, IHttpContextAccessor httpContextAccessor)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.supportSecurity = supportSecurity;
            this.httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("CreateUserAsync")]
        public async Task<ActionResult<UserToken>> CreateUserAsync([FromBody] RegisterViewModel model)
        {

            UserToken userToken = new UserToken();
            try
            {
                var user = new ApplicationUser
                {
                    UserName = model.Username,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.MobileNo,
                    Country = model.Country,
                    RegistrationTime = DateTime.Now,
                    Dob = model.Dob.Value,
                    Gender = model.Gender
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var roleAssignResult = await userManager.AddToRoleAsync(user, "User");
                    if (roleAssignResult.Succeeded)
                    {
                        var role = await userManager.GetRolesAsync(user);
                        var userInfo = new UserInfo
                        {
                            Email = model.Email,
                            Name = $"{model.FirstName} {model.LastName}",
                            Username = model.Username,
                            Roles = role
                        };
                        userToken = supportSecurity.BuildToken(userInfo);
                        userToken.Status = "success";
                        return userToken;
                    }
                }
            }
            catch (Exception ex)
            {
                userToken.Status = $"failed, {ex.Message}";
            }

            userToken.Status = "failed";
            return userToken;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("LoginUserAsync")]
        public async Task<ActionResult<UserToken>> LoginUserAsync(LoginViewModel model)
        {
            UserToken userToken = new UserToken();
            var user = await userManager.FindByNameAsync(model.Username);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
                var loginLog = new LogForLogin
                {
                    UserName = user.FullName,
                    UserId = user.Id,
                    Ip_Address = httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString(),
                    TimeStamp = DateTime.Now,
                };
                if (result.Succeeded)
                {
                    loginLog.StatusFlag = 1;
                    await supportSecurity.InsertLogIntoLoginAsync(loginLog);
                    var role = await userManager.GetRolesAsync(user);
                    var userInfo = new UserInfo
                    {
                        Email = user.Email,
                        Name = user.FullName,
                        Username = model.Username,
                        Roles = role
                    };
                    userToken = supportSecurity.BuildToken(userInfo);
                    userToken.Status = "success";
                    return userToken;
                }
                else
                {
                    loginLog.StatusFlag = 0;
                    await supportSecurity.InsertLogIntoLoginAsync(loginLog);
                    userToken.Status = "Invalid Login Attempt";
                }

                if (result.IsLockedOut)
                {
                    string message = "Your account is locked, please try again after sometime or you may reset your password.";
                    userToken.Status = message;
                }
            }
            else
            {
                userToken.Status = "You have to register yourself with us!";
            }

            return userToken;
        }

        [HttpPost]
        [Route("CreateRoleAsync")]
        public async Task<IActionResult> CreateRoleAsync([FromBody] string roleName)
        {
            try
            {
                if (string.IsNullOrEmpty(roleName))
                {
                    return BadRequest("Your request is not valid, please resend it.");
                }

                var checkExistance = await roleManager.FindByNameAsync(roleName);
                if (checkExistance != null)
                {
                    return BadRequest("You have already created this role!");
                }

                IdentityRole role = new IdentityRole
                {
                    Name = roleName
                };
                var result = await roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return Ok($"{roleName} role has benn created successfully.");
                }

                List<IdentityError> li = new List<IdentityError>();
                foreach (var error in result.Errors)
                {
                    li.Add(new IdentityError
                    {
                        Code = error.Code,
                        Description = error.Description
                    });
                }

                return BadRequest(li);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving data from the database");
            }
        }

        [HttpGet]
        [Route("GetCountryListAsync")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountryListAsync()
        {
            return await dbContext.CountryMaster.ToListAsync();
        }

        [HttpGet]
        [Route("GetUserDetailsAsync")]
        public async Task<ActionResult<ApplicationUser>> GetUserDetailsAsync([FromBody] string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                var claims = supportSecurity.ParseClaimsFromJwt(token);
                string Username = string.Empty;
                foreach (var claim in claims)
                {
                    if (claim.Type == JwtRegisteredClaimNames.UniqueName)
                    {
                        Username = claim.Value;
                        break;
                    }
                }
                var user = await userManager.FindByNameAsync(Username);
                if (user != null)
                {
                    return user;
                }
            }
            return StatusCode(StatusCodes.Status400BadRequest, "User not found!");
        }

        [HttpGet]
        [Route("GetUserByNameAsync")]
        public async Task<ActionResult<ApplicationUser>> GetUserByNameAsync([FromBody] string Name)
        {
            return await dbContext.Users.FirstOrDefaultAsync(f => f.FullName.ToUpper() == Name.ToUpper());
        }

        [HttpPost]
        [Route("UpdateUserProfileAsync")]
        public async Task<ActionResult<string>> UpdateUserProfileAsync([FromBody] EditProfileViewModel model)
        {
            if (model != null)
            {
                try
                {
                    var user = await userManager.FindByIdAsync(model.userId);
                    if (user != null)
                    {
                        user.FirstName = model.FirstName;
                        user.LastName = model.LastName;
                        user.Email = model.Email;
                        user.PhoneNumber = model.MobileNumber;
                        var result = await dbContext.SaveChangesAsync();
                        return result.ToString();
                    }

                    return "This user is not registered with us!";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

            return "Failure";
        }


    }
}