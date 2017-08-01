using PLEXEDC.WEB.UI.Core;
using System;
using System.Web.Mvc;
using PLEXEDC.WEB.UI.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Security.Claims;
using PLEXEDC.WEB.BAL.Implementation;



namespace PLEXEDC.WEB.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //public readonly ISiebelServices siebelServices;
        private ApplicationDbContext db = new ApplicationDbContext();
        private InfowareService _inforwareService = new InfowareService();

        public HomeController()
        {//ISiebelServices siebelServices
            //this.siebelServices = siebelServices;
            
        }

        public ActionResult Index()
        {
            //if (Request.IsAuthenticated)
            //{
            //   siebelServices.SetClient(new SiebelReference.GetCustServiceRequestsClient());  
            //   var lst = siebelServices.Get(User.Identity.Name);

            //    ServiceRequestViewModel srvm = new ServiceRequestViewModel();

            //    srvm.ServiceRequests = lst;
            var userId = User.Identity.GetUserName();
            var person = db.Person.Where(c => c.ApplicationUserId == userId).First();
            string siebelId = person.SiebelId;
            ViewBag.InfowareId = person.InfowareId;
            ViewBag.LastLoginDate = person.LastLoginDate.ToShortDateString();
            return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Account");
            //}
        }

        

        public ActionResult Account()
        {
            var userId = User.Identity.GetUserName();
            var person = db.Person.Where(c => c.ApplicationUserId == userId).First();
         
            ViewBag.InfowareId = person.InfowareId;
            ViewBag.LastLoginDate = person.LastLoginDate.ToShortDateString();

            var cscs = _inforwareService.GetCSCSNumber(person.InfowareId);
            ViewBag.AccountNumber = cscs.Select(c => c.CsCsAcct).First();
            


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}