#pragma checksum "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Pages\Errors\AccessDenied.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3fd303a6bc82fe84b2cc7789563fb3791b7aa68"
// <auto-generated/>
#pragma warning disable 1591
namespace FriendsForever_App.Pages.Errors
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(ErrorLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Error/AccessDenied")]
    public partial class AccessDenied : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""jumbotron-fluid"">
    <div class=""row"">
        <div class=""col-sm-12 text-center"">
            <h4><span class=""border-bottom text-danger"">Access Denied</span></h4>
        </div>
        <div class=""col-sm-12 mt-5 text-center"">
            <div class=""p-5"">
                <img src=""/Images/stop-animation.gif"" alt=""AccessDenied"" class=""img-fluid"">
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
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
