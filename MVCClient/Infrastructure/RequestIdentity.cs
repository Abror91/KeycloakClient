using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using static IdentityModel.OidcConstants;

namespace MVCClient.Infrastructure
{
    public class RequestIdentity
    {
        public static async Task<JwtSecurityToken> Query()
        {

            var client = new HttpClient();
          
            var tokenresponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = "http://178.33.123.109:8080/auth/realms/dev/protocol/openid-connect/token",
                ClientId = "btc",
                ClientSecret = "381c1d29-2309-4529-a268-df162b0ec74c",
                Scope = "profile"
            });

            var accessToken = tokenresponse.AccessToken;

            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(accessToken);
            var tokens = handler.ReadToken(tokenresponse.AccessToken) as JwtSecurityToken;
            return tokens;

            //return claimItems;
            //var tokenS = handler.ReadToken(tokenJwtReponse.access_token) as JwtSecurityToken;
            //var value = JArray.Parse(claimItems);
            // return value.ToString();
        }

        public static async Task<string> RequestApi()
        {
            var client = new HttpClient();
            var tokenresponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = "http://178.33.123.109:8080/auth/realms/dev/protocol/openid-connect/token",
                ClientId = "btc",
                ClientSecret = "381c1d29-2309-4529-a268-df162b0ec74c",
                Scope = "profile"
            });
            var apiClient = new HttpClient();
            apiClient.SetBearerToken(tokenresponse.AccessToken);
            var response = await apiClient.GetAsync("http://localhost:49710/api/values");
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
