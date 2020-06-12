using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendsForever_App.Auth;
using FriendsForever_App.Services;
using FriendsForever_Library.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;

namespace FriendsForever_App
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }   

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSyncfusionBlazor();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddProtectedBrowserStorage();
            services.AddHttpClient();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.Configure<reCAPTCHAVerificationOptions>(Configuration.GetSection("reCAPTCHA"));
            services.AddScoped<JWTAuthenticationProvider>();
            services.AddScoped<AuthenticationStateProvider, JWTAuthenticationProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationProvider>());
            services.AddScoped<ILoginService, JWTAuthenticationProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationProvider>());
            services.AddHttpClient();
            services.AddHttpClient<IUserService, UserService>(options =>
            {
                options.BaseAddress = new Uri("https://localhost:44363/api/Account/");
                options.DefaultRequestHeaders.Add("User-Client", "Friends Forever Account Service");
            });
            services.AddHttpClient<ICenterService, CenterService>(options =>
            {
                options.BaseAddress = new Uri("https://localhost:44363/api/Service/");
                options.DefaultRequestHeaders.Add("User-Client", "Friends Forever Data Service");
            });
            services.AddScoped<CaptchaService>();
            services.AddSingleton<DataProtectionPurposeStrings>();
            services.Configure<DataProtectionTokenProviderOptions>(options => options.TokenLifespan = TimeSpan.FromDays(1));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Configuration.GetSection("SyncfusionLicenseKey").Value);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMvcWithDefaultRoute();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
