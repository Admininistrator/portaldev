using PLEXEDC.WEB.DAL.Models;
using PLEXEDC.WEB.UI.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PLEXEDC.WEB.UI.Implementation
{
    public class SiebelServices : ISiebelServices
    {
        public SiebelReference.EDC_spcSR_spcDetailsClient client;

        //public List<ServiceRequestModel> ServiceRequests = new List<ServiceRequestModel> {
        //    new ServiceRequestModel {  Area = "Area0", ContactId = "ContactId0",  Status = "Status0", SubArea = "SubArea0" },
        //    new ServiceRequestModel {  Area = "Area1", ContactId = "ContactId1",  Status = "Status1", SubArea = "SubArea1" },
        //    new ServiceRequestModel {  Area = "Area2", ContactId = "ContactId2",  Status = "Status2", SubArea = "SubArea2"},
        //    new ServiceRequestModel {  Area = "Area3", ContactId = "ContactId3",  Status = "Status3", SubArea = "SubArea3" },
        //    new ServiceRequestModel {  Area = "Area4", ContactId = "ContactId4",  Status = "Status4", SubArea = "SubArea4" },
        //    new ServiceRequestModel {  Area = "Area5", ContactId = "ContactId5",  Status = "Status5", SubArea = "SubArea5" },
        //    new ServiceRequestModel {  Area = "Area6", ContactId = "ContactId6",  Status = "Status6", SubArea = "SubArea6" },
        //    new ServiceRequestModel {  Area = "Area7", ContactId = "ContactId7",  Status = "Status7", SubArea = "SubArea7"},
        //    new ServiceRequestModel {  Area = "Area8", ContactId = "ContactId8",  Status = "Status8", SubArea = "SubArea8" },
        //    new ServiceRequestModel {  Area = "Area9", ContactId = "ContactId9",  Status = "Status9", SubArea = "SubArea9"},
        //    new ServiceRequestModel {  Area = "Area10", ContactId = "ContactId10",  Status = "Status10", SubArea = "SubArea10"},
        //    new ServiceRequestModel {  Area = "Area11", ContactId = "ContactId11",  Status = "Status11", SubArea = "SubArea11"}
        //};

        //public void SetClient(GetCustServiceRequestsClient getCustServiceRequestsClient)
        //{
        //    this.client = getCustServiceRequestsClient;
        //}

        public void SetClient(SiebelReference.EDC_spcSR_spcDetailsClient Client)
        {
            this.client = Client;
        }

        public SiebelServices()
        {

        }

        public ServiceRequestModel Create(ServiceRequestModel request)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ServiceRequestModel request)
        {
            throw new NotImplementedException();
        }

        //public List<ServiceRequestModel> GetCustomersSRs(GetCustomersSRs_Input input)
        //{
        //    return ServiceRequests.Where(x => x.CustomerId == input.CustomerId).ToList();
        //}

        public List<ServiceRequestModel> Get(string customerId)
        {
            var model = new SiebelReference.EDC_spcSR_spcDetails_Input();
            model.CustomerId = customerId;
            List<ServiceRequestModel> requestDetails = new List<ServiceRequestModel>();

            client.Open();
            
           

            if (client != null)
            {
                client.Open();
                client.ChannelFactory.Credentials.UserName.UserName = "admin";
                requestDetails = client.EDC_spcSR_spcDetails(model).ListOf_ServiceRequest.Select(x => new ServiceRequestModel {
                    Area = x.CitizenId,
                    CitizenId = x.CitizenId,
                    ClosureComment = x.ClosureComments,
                    Priority = x.Priority,
                    SRNumber = x.SRNumber,
                    Status = x.Status,
                    SubArea = x.SubArea,
                    Summary = x.Summary,
                    Type = x.Type
                }).ToList();
            }

              return requestDetails;
        }
        public ServiceRequestModel Update(ServiceRequestModel request)
        {
            throw new NotImplementedException();
        }
    }
}
