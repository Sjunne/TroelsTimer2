﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Text.Json;
using SimpleLogn.Data;
using SimpleLogn.Models;


namespace SimpleLogn.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime jsRuntime;

        
        private User cachedUser;
        private IUserService userService;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserService userService)
        {
            this.jsRuntime = jsRuntime;
            this.userService = userService;
        }
        
        
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();

            if (cachedUser == null)
            {
                string userAsJson = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson))
                {
                    cachedUser = JsonSerializer.Deserialize<User>(userAsJson);
                    identity = SetupClaimsForUser(cachedUser);
                }
            }
            else
            {
                    identity = SetupClaimsForUser(cachedUser);
            }
            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }


        public void ValidateLogin(string username, string password)
        {
            Console.WriteLine("Validate log in");
            if (string.IsNullOrEmpty(username)) throw new Exception("Enter Username");
            if (string.IsNullOrEmpty(password)) throw new Exception("Enter Password");
            
            ClaimsIdentity identity = new ClaimsIdentity();
            try
            {
                User user = userService.ValidateUser(username, password);
                identity = SetupClaimsForUser(user);
                string serialisedDate = JsonSerializer.Serialize(user);
                jsRuntime.InvokeVoidAsync("sessionStorage.getitem", "currentUser", serialisedDate);
                cachedUser = user;
            }
            catch (Exception e)
            {
                throw e;
            }
            
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState((new ClaimsPrincipal(identity)))));
        }


        public void Logout()
        {
            cachedUser = null;
            var user = new ClaimsPrincipal();
            jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        private ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim("Role", user.Role));
            claims.Add(new Claim("City", user.City));
            claims.Add(new Claim("Domain", user.Domain));
            claims.Add(new Claim("BirthYear", user.BirthYear.ToString()));
            claims.Add(new Claim("Level", user.SecurityLevel.ToString()));
            
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}