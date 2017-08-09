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

            var model = new CustomerAccountViewModel();

            var cscs = _inforwareService.GetCSCSNumber(person.SessionId, person.InfowareId);
            model.AccountNumber = cscs.Select(c => c.CsCsAcct).First();
            model.StockListing = _inforwareService.GetPortFolio(person.SessionId, person.InfowareId);
            model.TransactionListing = _inforwareService.GetAccountOverView(person.SessionId, person.InfowareId);
            
            return View(model);
        }

        public ActionResult Trade()
        {
            var userId = User.Identity.GetUserName();
            var person = db.Person.Where(c => c.ApplicationUserId == userId).First();

            ViewBag.InfowareId = person.InfowareId;
            ViewBag.LastLoginDate = person.LastLoginDate.ToShortDateString();

            var model = new TradeViewModel();

            model.OpenOrder = _inforwareService.GetOpenOrder(person.SessionId, person.InfowareId);
            model.TradableStock = _inforwareService.GetTradableStock(person.SessionId, person.InfowareId);
            
            return View(model);
        }
    }
}