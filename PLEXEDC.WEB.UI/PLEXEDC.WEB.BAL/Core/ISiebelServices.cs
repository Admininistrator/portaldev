using PLEXEDC.WEB.DAL.Models;
using System.Collections.Generic;

namespace PLEXEDC.WEB.BAL.Core
{
    public interface ISiebelServices
    {
        List<ServiceRequestModel> GetDetail(string customerId);
        List<ServiceRequestActivityModel> GetActivity();
        ServiceRequestModel Update(ServiceRequestModel request);
        void Create(ServiceRequestModel request);
        bool Delete(ServiceRequestModel request);
        
    }
}
