#pragma checksum "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d534d0e55981989e1ceb91991655b55d1a584f"
// <auto-generated/>
#pragma warning disable 1591
namespace FriendsForever_App.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.AddMarkupContent(1, "\r\n    \r\n    ");
            __builder.OpenElement(2, "nav");
            __builder.AddAttribute(3, "class", "navbar navbar-expand-lg");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddMarkupContent(8, "<a class=\"navbar-brand text-white\" href=\"#\"><i class=\"fas fa-user-friends fa-lg mr-2\"></i>Friends Forever</a>\r\n            ");
            __builder.AddMarkupContent(9, "<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#nvbCollapse\" aria-controls=\"nvbCollapse\">\r\n                <i class=\"fas fa-bars\"></i>\r\n            </button>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "collapse navbar-collapse");
            __builder.AddAttribute(12, "id", "nvbCollapse");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "navbar-nav ml-auto");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<li class=\"nav-item active pl-1\">\r\n                        <a class=\"nav-link\" href=\"#\"><i class=\"fas fa-home fa-fw mr-1\"></i>Home</a>\r\n                    </li>\r\n                    ");
            __builder.AddMarkupContent(18, @"<li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-plus-circle fa-fw mr-1""></i>Create
                        </a>
                        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                            <a class=""dropdown-item"" href=""#""><i class=""fas fa-clone fa-fw mr-1""></i>New Post</a>
                            <a class=""dropdown-item"" href=""#""><i class=""fas fa-plus-circle fa-fw mr-1""></i>New Story</a>
                        </div>
                    </li>
                    ");
            __builder.AddMarkupContent(19, @"<li class=""nav-item pl-1"">
                        <a class=""nav-link"" href=""#"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Friends List"">
                            <i class=""fas fa-user-friends fa-fw mr-1""></i>&nbsp;<span class=""d-sm-block d-md-none"">Friends</span>
                        </a>
                    </li>
                    ");
            __builder.AddMarkupContent(20, @"<li class=""nav-item pl-1"">
                        <a class=""nav-link"" href=""#"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Messages"">
                            <i class=""fab fa-facebook-messenger fa-fw mr-1""></i>&nbsp;<span class=""d-sm-block d-md-none"">Messages</span>
                        </a>
                    </li>
                    ");
            __builder.AddMarkupContent(21, @"<li class=""nav-item pl-1"">
                        <a class=""nav-link"" href=""#"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Notification"">
                            <i class=""fas fa-bell fa-fw mr-1""></i><span class=""d-sm-block d-md-none"">Notification</span>
                        </a>
                    </li>
                    ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item pl-1");
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "class", "nav-link");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Shared\NavMenu.razor"
                                                      LogoutUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Logout");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\SocialNetwork\FriendsForever_App\Shared\NavMenu.razor"
      
    public async Task LogoutUser()
    {
        await loginService.Logout();
        navigationManager.NavigateTo("Login", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
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
