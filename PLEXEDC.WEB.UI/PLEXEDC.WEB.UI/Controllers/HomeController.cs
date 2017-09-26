using System.Web.Mvc;
using PLEXEDC.WEB.UI.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Services.Protocols;
using PLEXEDC.WEB.BAL.Implementation;

namespace PLEXEDC.WEB.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly SiebelServices _siebelServices;
        private ApplicationDbContext db;
        private InfowareService _inforwareService;
        //SiebelReference.EDC_spcSR_spcDetailsClient client = new SiebelReference.EDC_spcSR_spcDetailsClient();

        public HomeController()
        {
            db = new ApplicationDbContext();
            _inforwareService = new InfowareService();
            //ISiebelServices siebelServices
            this._siebelServices = new SiebelServices();
        }

        public ActionResult Index()
        {
            var model = new IndexViewModel();
            var userId = User.Identity.GetUserName();
            var person = db.Person.Where(c => c.ApplicationUserId == userId).First();
            string siebelId = person.SiebelId;
            model.RequesList = _siebelServices.GetDetail(siebelId);
            ViewBag.InfowareId = person.InfowareId;
            string sessionId = person.SessionId;
            ViewBag.LastLoginDate = person.LastLoginDate.ToShortDateString();
            return View(model);
        }
    }
}