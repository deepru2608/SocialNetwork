#pragma checksum "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2517c8ed9c96f88e94e3c6847de72376111f250c"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class FriendsRequest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .customHoverEffect {
        padding: 10px;
        margin-bottom: -10px;
    }

        .customHoverEffect:hover {
            background-color: #EAF0F1;
            padding: 10px;
            margin-bottom: -10px;
            border-radius: 2px;
            color: #4834DF;
        }

    .fixed-content {
        top: 0;
        bottom: 0;
        position: relative;
        overflow-y: scroll;
        overflow-x: hidden;
        max-height: 300px;
    }
</style>


");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card card-cascade");
            __builder.AddMarkupContent(3, "\r\n    \r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body card-body-cascade fixed-content");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<p style=\"padding-top: 2px; font-size: 18px\" class=\"text-primary text-center border-bottom\">Friends Request</p>\r\n");
#nullable restore
#line 30 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor"
         if (NewFriendsRequest.Any())
        {
            foreach (var friends in NewFriendsRequest)
            {
                var photoData = (friends.ProfilePhotoPath ?? "Microsoft_Default.png");

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "pb-2");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "customHoverEffect");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "p");
            __builder.AddMarkupContent(16, "\r\n                            ");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "src", "Images/ProfileImage/" + (
#nullable restore
#line 38 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor"
                                                           photoData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "alt", "Avatar");
            __builder.AddAttribute(20, "class", "rounded-circle");
            __builder.AddAttribute(21, "style", "width: 35px;height: 35px;");
            __builder.CloseElement();
            __builder.AddContent(22, " ");
            __builder.AddMarkupContent(23, "<span style=\"font-size: 13px;\">Deepanshu</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-6");
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(31);
            __builder.AddAttribute(32, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor"
                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "Content", "Accept");
            __builder.AddAttribute(34, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor"
                                                                                       e => AcceptFriendRequest(friends.EncryptFullName)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-6");
            __builder.AddMarkupContent(39, "\r\n                                ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(40);
            __builder.AddAttribute(41, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor"
                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "Content", "Reject");
            __builder.AddAttribute(43, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor"
                                                                                       e => RejectFriendRequest(friends.EncryptFullName)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 51 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Notifications.SfToast>(52);
            __builder.AddAttribute(53, "ID", "toast_type_request");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Notifications.ToastPosition>(56);
                __builder2.AddAttribute(57, "X", "Right");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(59, (__value) => {
#nullable restore
#line 56 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor"
               RequestToastObj = (Syncfusion.Blazor.Notifications.SfToast)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\FriendsRequest.razor"
       
    SfToast RequestToastObj;
    public IEnumerable<ShowFriendsReuqestData> NewFriendsRequest = new List<ShowFriendsReuqestData>();
    private IDataProtector dataProtector;

    protected override async Task OnInitializedAsync()
    {
        var user = await userService.GetUserDetailsAsync();
        dataProtector = dataProtectionProvider.CreateProtector(dataProtectionPurposeStrings.RouteValue);
        NewFriendsRequest = await centerService.GetNewFriendsRequestAsync(user.Id);
        foreach (var item in NewFriendsRequest)
        {
            string encFullName = dataProtector.Protect(item.SenderFullName);
            item.EncryptFullName = encFullName;
        }
    }

    protected async Task AcceptFriendRequest(string encName)
    {
        string FullName = string.Empty;
        if (encName != null)
        {
            FullName = dataProtector.Unprotect(encName);
        }
        var friendSenderUser = await userService.GetUserByNameAsync(FullName);
        var friendRequestUser = await userService.GetUserDetailsAsync();
        if (friendSenderUser != null)
        {
            Friends friend = new Friends
            {
                Status = "Accept",
                UserIdRequest = friendSenderUser.Id
            };
            var updateResult = await centerService.AcceptRejectRequestUpdateAsync(friend);
            if (updateResult > 0)
            {
                Friends friends = new Friends
                {
                    UserIdRequest = friendRequestUser.Id,
                    UserIdResponse = friendSenderUser.Id,
                    Time_Stamp = DateTime.Now,
                    UniqueId = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
                    Status = "Accept"
                };

                var result = await centerService.InsertFriendsReuqestDataAsync(friends);
                if (result > 0)
                {
                    string message = $"You have accepted {friendRequestUser.FullName} request succesfully.";
                    await RequestToastObj.Show(new ToastModel { Title = "Success!", Content = message, CssClass = "e-toast-success", Icon = "e-success toast-icons" });
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    navigationManager.NavigateTo("/", true);
                }
                else
                {
                    string message = "We are facing some technical issue, please try again later!";
                    await RequestToastObj.Show(new ToastModel { Title = "Error!", Content = message, CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    navigationManager.NavigateTo("/", true);
                }
            }
        }
    }

    protected async Task RejectFriendRequest(string encName)
    {
        string FullName = string.Empty;
        if (encName != null)
        {
            FullName = dataProtector.Unprotect(encName);
        }
        var friendSenderUser = await userService.GetUserByNameAsync(FullName);
        if (friendSenderUser != null)
        {
            Friends friend = new Friends
            {
                Status = "Reject",
                UserIdRequest = friendSenderUser.Id
            };
            var result = await centerService.AcceptRejectRequestUpdateAsync(friend);
            if (result > 0)
            {
                string message = $"You have rejected {friendSenderUser.FullName} request succesfully.";
                await RequestToastObj.Show(new ToastModel { Title = "Success!", Content = message, CssClass = "e-toast-success", Icon = "e-success toast-icons" });
                await Task.Delay(TimeSpan.FromSeconds(2));
                navigationManager.NavigateTo("/", true);
            }
            else
            {
                string message = "We are facing some technical issue, please try again later!";
                await RequestToastObj.Show(new ToastModel { Title = "Error!", Content = message, CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
                await Task.Delay(TimeSpan.FromSeconds(2));
                navigationManager.NavigateTo("/", true);
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
