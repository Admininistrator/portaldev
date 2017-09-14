using Microsoft.AspNet.Identity;
using PLEXEDC.WEB.BAL.Implementation;
using PLEXEDC.WEB.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLEXEDC.WEB.UI.Controllers
{
    [Authorize]
    public class MyAccountController : Controller
    {
        private readonly SiebelServices _siebelServices;
        private ApplicationDbContext db;
        private InfowareService _inforwareService;
        //SiebelReference.EDC_spcSR_spcDetailsClient client = new SiebelReference.EDC_spcSR_spcDetailsClient();

            public MyAccountController()
        {
            _siebelServices = new SiebelServices();
            _inforwareService = new InfowareService();
            db = new ApplicationDbContext();
        }


        // GET: MyAccount
        public ActionResult Account()
        {
            var userId = User.Identity.GetUserName();
            var person = db.Person.Where(c => c.ApplicationUserId == userId).First();

            ViewBag.InfowareId = person.InfowareId;
            ViewBag.LastLoginDate = person.LastLoginDate.ToShortDateString();

            var model = new CustomerAccountViewModel();

            var cscs = _inforwareService.GetCSCSNumber(person.SessionId, person.InfowareId);
            if (cscs.Any())
            {
                model.AccountNumber = cscs.Select(c => c.CsCsAcct).First();
            }
            if (_inforwareService.GetPortFolio(person.SessionId, person.InfowareId).Any())
            {
                model.StockListing = _inforwareService.GetPortFolio(person.SessionId, person.InfowareId);
            }
            if (_inforwareService.GetAccountOverView(person.SessionId, person.InfowareId).Any())
            {
                model.TransactionListing = _inforwareService.GetAccountOverView(person.SessionId, person.InfowareId);
            }

            return View(model);
        }
    }
}