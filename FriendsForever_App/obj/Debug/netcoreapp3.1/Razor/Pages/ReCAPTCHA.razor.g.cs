#pragma checksum "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\Pages\ReCAPTCHA.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aed27188e441aad9e4228c9ee6d2e09be1bd20d"
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
#line 1 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_App.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_Library.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_Library.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\_Imports.razor"
using FriendsForever_App.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\Pages\ReCAPTCHA.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    public partial class ReCAPTCHA : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", 
#nullable restore
#line 4 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\Pages\ReCAPTCHA.razor"
          UniqueId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\deepa\Desktop\Blazor\Social Network College Project\SocialNetwork\FriendsForever_App\Pages\ReCAPTCHA.razor"
       

    [Parameter]
    public string SiteKey { get; set; }

    [Parameter]
    public EventCallback<string> OnSuccess { get; set; }

    [Parameter]
    public EventCallback OnExpired { get; set; }

    private string UniqueId = Guid.NewGuid().ToString();

    private int WidgetId;

    protected override async Task OnInitializedAsync()
    {
        await JS.InvokeAsync<object>("My.reCAPTCHA.init");
        WidgetId = await JS.InvokeAsync<int>("My.reCAPTCHA.render", DotNetObjectReference.Create(this), UniqueId, SiteKey);
    }

    [JSInvokable, EditorBrowsable(EditorBrowsableState.Never)]
    public void CallbackOnSuccess(string response)
    {
        if (OnSuccess.HasDelegate)
        {
            OnSuccess.InvokeAsync(response);
        }
    }

    [JSInvokable, EditorBrowsable(EditorBrowsableState.Never)]
    public void CallbackOnExpired()
    {
        if (OnExpired.HasDelegate)
        {
            OnExpired.InvokeAsync(null);
        }
    }

    public ValueTask<string> GetResponseAsync()
    {
        return JS.InvokeAsync<string>("My.reCAPTCHA.getResponse", WidgetId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CaptchaService captchaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
