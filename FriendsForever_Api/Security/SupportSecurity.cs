using FriendsForever_Api.Data;
using FriendsForever_Library.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FriendsForever_Api.Security
{
    public class SupportSecurity
    {
        private readonly IConfiguration configuration;
        private readonly AppDbContext dbContext;

        public SupportSecurity(IConfiguration configuration, AppDbContext dbContext)
        {
            this.configuration = configuration;
            this.dbContext = dbContext;
        }

        public UserToken BuildToken(UserInfo userInfo)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Username),
                new Claim(ClaimTypes.Email, userInfo.Email),
                new Claim(ClaimTypes.Name, userInfo.Name),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            foreach (var role in userInfo.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Expiration time
            var expiration = DateTime.UtcNow.AddDays(1);

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: configuration["Jwt:Site"],
               audience: configuration["Jwt:Site"],
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }

        public async Task<int> InsertLogIntoLoginAsync(LogForLogin model)
        {
            dbContext.LogTableForLogin.Add(model);
            return await dbContext.SaveChangesAsync();
        }

        public IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);
            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                keyValuePairs.Remove(ClaimTypes.Role);
            }

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));
            return claims;
        }

        public byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
