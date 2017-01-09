using PLEXEDC.WEB.UI.Core;
using PLEXEDC.WEB.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace PLEXEDC.WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        public readonly ISiebelServices siebelServices;

        public HomeController(ISiebelServices siebelServices)
        {
            this.siebelServices = siebelServices;
        }

        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
               siebelServices.SetClient(new SiebelReference.GetCustServiceRequestsClient());  
                var lst = siebelServices.Get(User.Identity.Name);

                ServiceRequestViewModel srvm = new ServiceRequestViewModel();

                srvm.ServiceRequests = lst;

                return View(srvm);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}