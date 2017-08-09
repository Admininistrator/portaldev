using PLEXEDC.WEB.BAL.Model;
using PLEXEDC.WEB.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.BAL.Core
{
    public interface ISiebelServices
    {
        List<ServiceRequestModel> Get(string customerId);
        ServiceRequestModel Update(ServiceRequestModel request);
        ServiceRequestModel Create(ServiceRequestModel request);
        bool Delete(ServiceRequestModel request);
    }
}
