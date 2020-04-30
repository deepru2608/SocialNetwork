using FriendsForever_Library.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FriendsForever_App.Services
{
    public class CaptchaService
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly IOptions<reCAPTCHAVerificationOptions> reCAPTCHAVerificationOptions;

        public CaptchaService(IHttpClientFactory httpClientFactory, 
            IOptions<reCAPTCHAVerificationOptions> reCAPTCHAVerificationOptions)
        {
            this.httpClientFactory = httpClientFactory;
            this.reCAPTCHAVerificationOptions = reCAPTCHAVerificationOptions;
        }

        public async Task<string> GetCaptchaVerification(SampleAPIArgs args)
        {
            string message = string.Empty;
            var url = "https://www.google.com/recaptcha/api/siteverify";
            var content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"secret", this.reCAPTCHAVerificationOptions.Value.Secret},
                {"response", args.reCAPTCHAResponse}
            });

            var httpClient = httpClientFactory.CreateClient();
            var response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var verificationResponse = response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<reCAPTCHAVerificationResponse>(verificationResponse.Result);
            if (result.Success)
            {
                message = "success";
                return message;
            }
            message = string.Join(", ", result.ErrorCodes.Select(err => err.Replace('-', ' ')));
            return message;
        }
    }
}
