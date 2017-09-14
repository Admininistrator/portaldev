using PLEXEDC.WEB.DAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PLEXEDC.WEB.UI.Models
{
    public class ServiceRequestViewModel
    {
        [Required(ErrorMessage ="First Name required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        public string LastName { get; set; }

        [Required( ErrorMessage = "Please select an SR Area")]
        [Range(1, double.MaxValue, ErrorMessage = "Please select an SR Area")]
        public int Area { get; set; }

        public string CitizenId { get; set; }

        public string ClosureComments { get; set; }

        [Required(ErrorMessage = "Please select an SR Priority")]
        [Range(1, double.MaxValue, ErrorMessage = "Please select an SR Priority")]
        public int Priority { get; set; }

        public string SRNumber { get; set; }

        [Required(ErrorMessage = "Please select an SR Status")]
        [Range(1, double.MaxValue, ErrorMessage = "Please select an SR Status")]
        public int Status { get; set; }

        [Required( ErrorMessage = "Please select an SR Sub-Status")]
        [Range(1, double.MaxValue, ErrorMessage = "Please select an SR Status")]
        public int SubStatus { get; set; }

        [Required(ErrorMessage = "Please select an SR Sub-Area")]
        [Range(1, double.MaxValue, ErrorMessage = "Please select an SR Sub-Status")]
        public int SubArea { get; set; }

        public string Summary { get; set; }

        [Required(ErrorMessage = "Please select an SR Type")]
        [Range(1, double.MaxValue, ErrorMessage = "Please select an SR Type")]
        public int Type { get; set; }
        public IEnumerable<System.Web.Mvc.SelectListItem> TypeDropDown { get; set; }

        public IEnumerable<System.Web.Mvc.SelectListItem> AreaDropDown { get; set; }

        public IEnumerable<System.Web.Mvc.SelectListItem> SubAreaDropDown { get; set; }

        public IEnumerable<System.Web.Mvc.SelectListItem> StatusDropDown { get; set; }

        public IEnumerable<System.Web.Mvc.SelectListItem> SubStatusDropDown { get; set; }

        public IEnumerable<System.Web.Mvc.SelectListItem> PriorityDropDown { get; set; }

        public List<ServiceRequestModel> ServiceRequests { get;  set; }

        public List<ServiceRequestActivityModel> ServiceRequestsActivity { get; set; }
    }
}