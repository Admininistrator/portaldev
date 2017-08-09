using PLEXEDC.WEB.BAL.Models;
using PLEXEDC.WEB.UI.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLEXEDC.WEB.UI.SiebelReference;
using PLEXEDC.WEB.BAL.Model;

namespace PLEXEDC.WEB.UI.Core
{
    public interface ISiebelServices
    {
        List<ServiceRequestModel> Get(string customerId);
        ServiceRequestModel Update(ServiceRequestModel request);
        ServiceRequestModel Create(ServiceRequestModel request);
        bool Delete(ServiceRequestModel request);
        void SetClient(GetCustServiceRequestsClient getCustServiceRequestsClient);
    }
}
