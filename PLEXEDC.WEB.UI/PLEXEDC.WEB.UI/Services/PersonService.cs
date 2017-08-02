using PLEXEDC.WEB.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Net;

namespace PLEXEDC.WEB.UI.Services
{
    public class PersonService
    {
        
        private ApplicationDbContext db;

        public PersonService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreatePerson(ApplicationUserManager person, DateTime lastLogin)
        {
            var Person = new Person
            {
                SiebelId = person.SiebelId,
                CalypsoId = person.CalypsoId,
                InfowareId = person.InfowareId,
                SessionId = person.SessionId,
                LastLoginDate = lastLogin,
                ApplicationUserId = person.Id
            };
            db.Person.Add(Person);
            db.SaveChanges();
        }

        public void UpdatePerson(string userId)
        {
            var user = db.Person.Where(c => c.ApplicationUserId == userId).First();
            user.LastLoginDate = DateTime.Now;
            user.SessionId = getSessionId();
            db.Person.Attach(user);
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }

        private string getSessionId()
        {
            String jsonString = System.IO.File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/InfowareLogin.json"));
            JObject obj = JObject.Parse(jsonString);

            JToken outValue = obj["OutValue"];
            string sessionId = outValue.ToString();

            return sessionId;
        }
    }
}