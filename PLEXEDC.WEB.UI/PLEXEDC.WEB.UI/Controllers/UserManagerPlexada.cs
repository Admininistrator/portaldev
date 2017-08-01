using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PLEXEDC.WEB.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace PLEXEDC.WEB.UI.Controllers
{
   

    public class UserManagerPlexada : UserManager<Models.ApplicationUserManager>
    {
        public UserManagerPlexada(IUserStore<Models.ApplicationUserManager> store) : base(store)
        {

        }

        public override async Task<ClaimsIdentity> CreateIdentityAsync(Models.ApplicationUserManager user, string authenticationType)
        {
            IList<Claim> claimCollection = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Id),
                new Claim(ClaimTypes.Country, "Nigeria"),
                new Claim(ClaimTypes.Email, user.UserName),
                
            };


            //var claimsIdentity = new ClaimsIdentity(claimCollection, "Company Portal");

            var claimsIdentity = new ClaimsIdentity(claimCollection, DefaultAuthenticationTypes.ApplicationCookie);
           
            return await Task.Run(() => claimsIdentity);
        }
    }
}
