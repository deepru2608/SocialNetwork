#pragma checksum "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\CommentBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f41efe58ea9e70cd9f8a796f7e2a5e55d059b240"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FriendsForever_App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_App.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_Library.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_Library.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_App.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_App.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.DataProtection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CommentBox/{postId}")]
    public partial class CommentBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 190 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\CommentBox.razor"
       
    SfToast CommentToastObj;
    [Parameter]
    public string postId { get; set; }
    public string CommentBoxArea { get; set; }
    public IEnumerable<PostImages> AllPhotos = new List<PostImages>();
    public List<CountPostImages> PostPhotoCount = new List<CountPostImages>();
    public Post PostsDetails = new Post();
    public IEnumerable<ShowCommentsViewModel> ShowCommentsList = new List<ShowCommentsViewModel>();
    public string signInUserName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        List<string> UserIdList = new List<string>();
        var user = await userService.GetUserDetailsAsync();
        int count = await centerService.CheckPostTableDataAsync(user.Id);
        if (count > 0)
        {
            signInUserName = user.FullName;
            PostsDetails = await centerService.FindPostDetailsByIdAsync(postId);
            List<PostImages> postImagesList = new List<PostImages>();
            var result = await centerService.FindPostImagesByPostIdAsync(PostsDetails.PostedId);
            PostPhotoCount.Add(new CountPostImages
            {
                PostedId = PostsDetails.PostedId,
                PostPhotoCount = result.Count()
            });
            foreach (var postImages in result)
            {
                PostImages postImages1 = new PostImages
                {
                    Id = postImages.Id,
                    PostedId = postImages.PostedId,
                    PostedPhoto = postImages.PostedPhoto
                };
                postImagesList.Add(postImages1);
            }
            AllPhotos = postImagesList;
        }

        IEnumerable<Comments> CommentsList = await centerService.GetCommentsListByPostIdAsync(postId);
        List<ShowCommentsViewModel> model = new List<ShowCommentsViewModel>();
        foreach (var comment in CommentsList)
        {
            ShowCommentsViewModel showComments = new ShowCommentsViewModel();
            showComments.Id = comment.Id;
            showComments.UserComment = comment.Comment;
            string commentedUserId = comment.CommentedUserId;
            var commentedUserDetails = await userService.GetUserByIdAsync(commentedUserId);
            showComments.OwnerName = commentedUserDetails.FullName;
            showComments.OwnerProfile = commentedUserDetails.ProfilePhotoPath;
            model.Add(showComments);
        }

        ShowCommentsList = model;
    }

    async Task InsertLikes(string postId)
    {
        var user = await userService.GetUserDetailsAsync();
        var duplicateLikes = new DuplicateLikesViewModel()
        {
            userId = user.Id,
            postId = postId
        };
        var count = await centerService.CheckDuplicateLikesAsync(duplicateLikes);
        if (count > 0)
        {
            await CommentToastObj.Show(new ToastModel { Title = "Error!", Content = "You have already liked it!", CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
        }
        else
        {
            var newLike = new Likes
            {
                PostedId = postId,
                LikeUserId = user.Id,
                LikeTimeStamp = DateTime.Now
            };
            var result = await centerService.InsertPostLikesAsync(newLike);
            if (result > 0)
            {
                var likeUpdation = await centerService.UpdatePostMasterLikesAsync(postId);
                if (likeUpdation > 0)
                {
                    await CommentToastObj.Show(new ToastModel { Title = "Success!", Content = "Like updated successfully.", CssClass = "e-toast-success", Icon = "e-success toast-icons" });
                    var post = await centerService.FindPostDetailsByIdAsync(postId);
                    if (post != null)
                    {
                        if (PostsDetails.PostedId == post.PostedId)
                        {
                            PostsDetails.LikesCount = post.LikesCount;
                            PostsDetails.CommentsCount = post.CommentsCount;
                        }
                    }
                }
                else
                {
                    await CommentToastObj.Show(new ToastModel { Title = "Error!", Content = "No updation pending!", CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
                }
            }
            else
            {
                await CommentToastObj.Show(new ToastModel { Title = "Error!", Content = "Invalid request, please try after sometimes!", CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
            }
        }

        await Task.Delay(TimeSpan.FromSeconds(2));
        StateHasChanged();
    }

    async Task InsertComments(string postId)
    {
        var user = await userService.GetUserDetailsAsync();
        if (string.IsNullOrEmpty(CommentBoxArea))
        {
            await jS.ShowAlert("Please enter your comment first!");
        }
        else
        {
            var newComment = new Comments
            {
                PostedId = postId,
                CommentedUserId = user.Id,
                Comment = CommentBoxArea,
                CommentedTimeStamp = DateTime.Now
            };
            var result = await centerService.InsertPostCommentsAsync(newComment);
            if (result > 0)
            {
                var commentUpdation = await centerService.UpdatePostMasterCommentsAsync(postId);
                if (commentUpdation > 0)
                {
                    StateHasChanged();
                }
                else
                {
                    await jS.ShowAlert("No updation pending!");
                }
            }
            else
            {
                await jS.ShowAlert("Invalid request, please try after sometimes!");
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment hostingEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataProtectionPurposeStrings dataProtectionPurposeStrings { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataProtectionProvider dataProtectionProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage protectedSessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICenterService centerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CaptchaService captchaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
