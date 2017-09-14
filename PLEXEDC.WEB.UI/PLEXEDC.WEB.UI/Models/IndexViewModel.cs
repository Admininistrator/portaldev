using PLEXEDC.WEB.DAL.Models;
using System.Collections.Generic;

namespace PLEXEDC.WEB.UI.Models
{
    public class IndexViewModel
    {
        public List<ServiceRequestModel> RequestDetail { get; set; }
        public List<ServiceRequestActivityModel> RequestActivity { get; set; }
    }
}