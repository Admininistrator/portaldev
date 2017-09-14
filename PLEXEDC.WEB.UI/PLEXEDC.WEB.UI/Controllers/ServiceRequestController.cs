using Microsoft.AspNet.Identity;
using PLEXEDC.WEB.BAL.Implementation;
using PLEXEDC.WEB.DAL.Models;
using PLEXEDC.WEB.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLEXEDC.WEB.UI.Controllers
{
    [Authorize]
    public class ServiceRequestController : Controller
    {
        private readonly SiebelServices _siebelServices;
        private ApplicationDbContext db;
        private InfowareService _inforwareService = new InfowareService();

        public ServiceRequestController()
        {
            db = new ApplicationDbContext();
            _siebelServices = new SiebelServices();
        }

        private IEnumerable<SelectListItem> GetSRType()
        {
             int? selectedItem = null ;
            var AllSRType = db.SRType.OrderBy(x => x.Name).ToList();

            AllSRType.Insert(0, new SRType { Id = 0, Name = "--Select SR Type--" });
            return AllSRType.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString(), Selected = x.Id == selectedItem});
        }



        private IEnumerable<SelectListItem> GetSRAreaEmpty()
        {
            int? selectedItem = null;
            var allUnit = new List<SRArea>();

            return allUnit.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString(), Selected = x.Id == selectedItem });
        }

        [HttpPost]
        public ActionResult  GetSRAreaNew(int? typeId)
        {
            var srArea = db.SRArea.Where(x => x.SRTypeId == typeId.Value).OrderBy(x => x.Name).ToList();
            srArea.Insert(0, new SRArea { Id = 0, Name = "--Select SR Area--" });
            return Json(new SelectList(srArea, "Id", "Name"));
        }

        private IEnumerable<SelectListItem> GetSRSubArea()
        {
           int? selectedItem = null;

            var AllSRType = new List<SRSubArea>();
            return AllSRType.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString(), Selected = x.Id == selectedItem });
        }

        [HttpPost]
        public ActionResult GetSRSubAreaNew(int? areaId)
        {
            var srSubArea = db.SRSubArea.Where(x => x.SRAreaId == areaId.Value).OrderBy(x => x.Name).ToList();
            srSubArea.Insert(0, new SRSubArea { Id = 0, Name = "--Select SR Sub-Area--" });
            return Json(new SelectList(srSubArea, "Id", "Name"));
        }

        private IEnumerable<SelectListItem> GetSRStatus()
        {
            int? selectedItem = null;

            var AllSRType = db.SRStatus.OrderBy(x => x.Name).ToList();

            AllSRType.Insert(0, new SRStatus { Id = 0, Name = "--Select SR Status--" });
            return AllSRType.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString(), Selected = x.Id == selectedItem });
        }

        private IEnumerable<SelectListItem> GetSRSubStatus()
        {
            int? selectedItem = null;
            var AllSRType = db.SRSubStatus.OrderBy(x => x.Name).ToList();

            AllSRType.Insert(0, new SRSubStatus { Id = 0, Name = "--Select SR Sub-Status--" });
            return AllSRType.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString(), Selected = x.Id == selectedItem });
        }

        private IEnumerable<SelectListItem> GetSRPriority()
        {
            int? selectedItem = null;

            var AllSRType = db.SRPriority.OrderBy(x => x.Name).ToList();

            AllSRType.Insert(0, new SRPriority { Id = 0, Name = "--Select SR Priority--" });
            return AllSRType.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString(), Selected = x.Id == selectedItem });
        }

        [HttpPost]
        public ActionResult getSRActivity(string srNumber)
        {
            var model = new ServiceRequestViewModel();
            model.ServiceRequestsActivity = _siebelServices.GetActivity().Where(x => x.SRNumber.Equals(srNumber)).ToList();
            return PartialView("_SRActivity", model);
        }

        // GET: ServiceRequest
        public ActionResult ServiceInformation()
        {
            var userId = User.Identity.GetUserName();
            var person = db.Person.Where(c => c.ApplicationUserId == userId).First();
            string siebelId = person.SiebelId;
            ViewBag.InfowareId = person.InfowareId;
            string sessionId = person.SessionId;
            ViewBag.LastLoginDate = person.LastLoginDate.ToShortDateString();

            var model = new ServiceRequestViewModel();
            
            model.ServiceRequests = _siebelServices.GetDetail("");
            model.TypeDropDown = GetSRType();
            model.AreaDropDown = GetSRAreaEmpty();
            model.SubAreaDropDown = GetSRSubArea();
            model.PriorityDropDown = GetSRPriority();
            //model.StatusDropDown = GetSRStatus();
            //model.SubStatusDropDown = GetSRSubStatus();
            model.CitizenId = person.SiebelId;

            return View(model);
        }

        [HttpPost]
        public ActionResult ServiceInformation(ServiceRequestViewModel model)
        {
            if (ModelState.IsValid)
            {
                var srequest = new ServiceRequestModel();
                srequest.Type = db.SRType.Where(t => t.Id == model.Type).First().Name;
                srequest.Area = db.SRArea.Where(r => r.Id == model.Area).First().Name;
                srequest.SubArea = db.SRSubArea.Where(s => s.Id == model.SubArea).First().Name;
                srequest.Status = "Open";
                srequest.SubStatus = "Unassigned" ;
                srequest.Priority = db.SRPriority.Where(p => p.Id == model.Priority).First().Name;
                srequest.CitizenId = model.CitizenId;
                srequest.Summary = model.Summary;

                _siebelServices.Create(srequest);
            }

            model.TypeDropDown = GetSRType();
            model.AreaDropDown = GetSRAreaEmpty();
            model.SubAreaDropDown = GetSRSubArea();
            model.PriorityDropDown = GetSRPriority();
            //model.StatusDropDown = GetSRStatus();
            //model.SubStatusDropDown = GetSRSubStatus();
            return View(model);
        }

    }
}
