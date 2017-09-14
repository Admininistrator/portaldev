using System.Collections.Generic;
using PLEXEDC.WEB.DAL.Models;

namespace PLEXEDC.WEB.UI.Core
{
    public interface ISiebelServices
    {
        List<ServiceRequestModel> Get(string customerId);
        ServiceRequestModel Update(ServiceRequestModel request);
        ServiceRequestModel Create(ServiceRequestModel request);
        bool Delete(ServiceRequestModel request);
        //void SetClient(GetCustServiceRequestsClient getCustServiceRequestsClient);
        void SetClient(SiebelReference.EDC_spcSR_spcDetailsClient client);
    }
}
