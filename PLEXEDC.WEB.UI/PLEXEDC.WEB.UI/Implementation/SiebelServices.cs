using PLEXEDC.WEB.UI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLEXEDC.WEB.BAL.Models;
using PLEXEDC.WEB.UI.SiebelReference;

namespace PLEXEDC.WEB.UI.Implementation
{
    //public class SiebelServices : ISiebelServices
    //{
    //    public GetCustServiceRequestsClient client;

    //    //public List<ServiceRequestModel> ServiceRequests = new List<ServiceRequestModel> {
    //    //    new ServiceRequestModel {  Area = "Area0", ContactId = "ContactId0", CustomerId = "123456789", Status = "Status0", SubArea = "SubArea0" },
    //    //    new ServiceRequestModel {  Area = "Area1", ContactId = "ContactId1", CustomerId = "123456789", Status = "Status1", SubArea = "SubArea1" },
    //    //    new ServiceRequestModel {  Area = "Area2", ContactId = "ContactId2", CustomerId = "123456789", Status = "Status2", SubArea = "SubArea2"},
    //    //    new ServiceRequestModel {  Area = "Area3", ContactId = "ContactId3", CustomerId = "123456789", Status = "Status3", SubArea = "SubArea3" },
    //    //    new ServiceRequestModel {  Area = "Area4", ContactId = "ContactId4", CustomerId = "123456789", Status = "Status4", SubArea = "SubArea4" },
    //    //    new ServiceRequestModel {  Area = "Area5", ContactId = "ContactId5", CustomerId = "123456789", Status = "Status5", SubArea = "SubArea5" },
    //    //    new ServiceRequestModel {  Area = "Area6", ContactId = "ContactId6", CustomerId = "123456789", Status = "Status6", SubArea = "SubArea6" },
    //    //    new ServiceRequestModel {  Area = "Area7", ContactId = "ContactId7", CustomerId = "123456789", Status = "Status7", SubArea = "SubArea7"},
    //    //    new ServiceRequestModel {  Area = "Area8", ContactId = "ContactId8", CustomerId = "123456789", Status = "Status8", SubArea = "SubArea8" },
    //    //    new ServiceRequestModel {  Area = "Area9", ContactId = "ContactId9", CustomerId = "123456789", Status = "Status9", SubArea = "SubArea9"},
    //    //    new ServiceRequestModel {  Area = "Area10", ContactId = "ContactId10", CustomerId = "123456789", Status = "Status10", SubArea = "SubArea10"},
    //    //    new ServiceRequestModel {  Area = "Area11", ContactId = "ContactId11", CustomerId = "123456789", Status = "Status11", SubArea = "SubArea11"}
    //    //};

    //    public void SetClient(GetCustServiceRequestsClient getCustServiceRequestsClient)
    //    {
    //        this.client = getCustServiceRequestsClient;
    //    }

    //    public SiebelServices()
    //    {
    //    }

    //    public ServiceRequestModel Create(ServiceRequestModel request)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool Delete(ServiceRequestModel request)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    //public List<ServiceRequestModel> GetCustomersSRs(GetCustomersSRs_Input input)
    //    //{
    //    //    //return ServiceRequests.Where(x => x.CustomerId == input.CustomerId).ToList();
    //    //}

    //    //public List<ServiceRequestModel> Get(string customerId)
    //    //{
    //    //    var model = new SiebelReference.GetCustomersSRs_Input();

    //    //    model.CustomerId = customerId;

    //    //    if(client != null)
    //    //    {
    //    //        return client.GetCustomersSRs(model).ListOfPlxServiceRequest.Select(x => new ServiceRequestModel {Area = x.Area, ContactId = x.ContactId, Status = x.Status, SubArea = x.SubArea,    }).ToList();
    //    //    }
    //    //    else
    //    //    {
    //    //        //return GetCustomersSRs(model);
    //    //        return ServiceRequests;
    //    //    }
    //    //}
    //    public ServiceRequestModel Update(ServiceRequestModel request)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
