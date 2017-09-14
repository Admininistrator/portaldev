using PLEXEDC.WEB.UI.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json.Linq;


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
            user.SessionId = GetSessionId();

            db.Person.Attach(user);
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }


        private string GetSessionId()
        {
            string sessionId = "";
            try
            {
                var client = new HttpClient();
                string jsonString = client.GetStringAsync("http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/login/123/admin2/passw0rd").Result;

                JObject jObj = JObject.Parse(jsonString);
                JToken outValue = jObj["OutValue"];
                sessionId = outValue.ToString();
            }
            catch
            {
                return sessionId;
            }
            return sessionId;
        }




    }
}