﻿using Microsoft.AspNet.Identity;
using PLEXEDC.WEB.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace PLEXEDC.WEB.UI.Controllers
{
   

    public class UserManagerPlexada : UserManager<ApplicationUser>
    {
        public UserManagerPlexada(IUserStore<ApplicationUser> store) : base(store)
        {

        }

       

        public override async Task<ClaimsIdentity> CreateIdentityAsync(ApplicationUser user, string authenticationType)
        {
            IList<Claim> claimCollection = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.SiebelId),
                new Claim(ClaimTypes.Country, "Nigeria"),
                new Claim(ClaimTypes.Email, user.UserName)
            };

            //var claimsIdentity = new ClaimsIdentity(claimCollection, "Company Portal");

            var claimsIdentity = new ClaimsIdentity(claimCollection, DefaultAuthenticationTypes.ApplicationCookie);

            return await Task.Run(() => claimsIdentity);
        }
    }
}
