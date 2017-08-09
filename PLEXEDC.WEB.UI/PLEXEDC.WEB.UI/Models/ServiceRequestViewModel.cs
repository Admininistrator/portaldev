using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PLEXEDC.WEB.BAL.Models;
using PLEXEDC.WEB.BAL.Model;

namespace PLEXEDC.WEB.UI.Models
{
    public class ServiceRequestViewModel
    {
        public List<ServiceRequestModel> ServiceRequests { get; internal set; }
    }
}