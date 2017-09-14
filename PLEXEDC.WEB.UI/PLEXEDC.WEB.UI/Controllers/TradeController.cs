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
    public class TradeController : Controller
    {
        private readonly SiebelServices _siebelServices;
        private ApplicationDbContext db;
        private InfowareService _inforwareService;

        public TradeController()
        {
            _siebelServices = new SiebelServices();
            _inforwareService = new InfowareService();
            db = new ApplicationDbContext();
        }
        // GET: Trade
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