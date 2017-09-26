using PLEXEDC.WEB.DAL.Models;
using System.Collections.Generic;

namespace PLEXEDC.WEB.BAL.Core
{
    public interface ISiebelServices
    {
        List<ServiceRequestModel> GetDetail(string customerId);
        List<ServiceRequestActivityModel> GetServiceRequestActivity();
        List<ServiceRequestModel> GetServiveRequest(string customerId);
        ServiceRequestModel Update(ServiceRequestModel request);
        SiebelReferenceCreate.CreateSR_Output Create(ServiceRequestModel request);
        bool Delete(ServiceRequestModel request);
        
    }
}
