using System;
using System.Collections.Generic;
using System.Linq;
using PLEXEDC.WEB.BAL.Core;
using PLEXEDC.WEB.DAL.Models;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Net;
using System.Web;
using System.Xml.Linq;
using System.Xml.XPath;

namespace PLEXEDC.WEB.BAL.Implementation
{
    public class SiebelServices : ISiebelServices
    {
        private SiebelReferenceCreate.EDC_spcCreate_spcSRClient _srCreatclient;
        private SiebelReferenceRequestGet.EDC_spcGet_spcContact_spcSR_spcWFClient _srReqestListClient;
        private SiebelReferenceAll.EDC_spcContact_spcGet_spcSR_spcActivity_spcWFClient _srRequestActivityClient;

        public void SetClient(SiebelReferenceCreate.EDC_spcCreate_spcSRClient srCreatClient, SiebelReferenceRequestGet.EDC_spcGet_spcContact_spcSR_spcWFClient srRequestListClient, SiebelReferenceAll.EDC_spcContact_spcGet_spcSR_spcActivity_spcWFClient srRequestActivityClient)
        {
            this._srCreatclient = srCreatClient;
            this._srReqestListClient = srRequestListClient;
            this._srRequestActivityClient = srRequestActivityClient;
        }

        public SiebelServices()
        {
            var srCreateClient = new SiebelReferenceCreate.EDC_spcCreate_spcSRClient();
            var srRequestListClient = new SiebelReferenceRequestGet.EDC_spcGet_spcContact_spcSR_spcWFClient();
            var srRequestActivityClient = new SiebelReferenceAll.EDC_spcContact_spcGet_spcSR_spcActivity_spcWFClient();
            SetClient(srCreateClient, srRequestListClient, srRequestActivityClient);
        }

        public SiebelReferenceCreate.CreateSR_Output Create(ServiceRequestModel model)
        {
            var srRequest_in = new SiebelReferenceCreate.CreateSR_Input();
            var srRequest_out = new SiebelReferenceCreate.CreateSR_Output();

            try
            {
                if (model != null)
                {
                    srRequest_in.Type = model.Type;
                    srRequest_in.Area = model.Area;
                    srRequest_in.SubArea = model.SubArea;
                    srRequest_in.Priority = model.Priority;
                    srRequest_in.CustomerNumber = model.CitizenId;
                    srRequest_in.Abstract = model.Summary;
                    srRequest_in.Source = model.Source;

                    srRequest_out = _srCreatclient.CreateSR(srRequest_in);
                }
            }
            catch
            {
                return srRequest_out;
            }
            return srRequest_out;
        }

        public List<ServiceRequestModel> GetServiveRequest(string customerId)
        {
            List<ServiceRequestModel> srRequestList = new List<ServiceRequestModel>();

            var srRequest_In = new SiebelReferenceRequestGet.EDC_spcGet_spcSR_spcList_Input();
            var srRequest_Out = new SiebelReferenceRequestGet.EDC_spcGet_spcSR_spcList_Output();

            srRequest_In.CustomerId = customerId;
            try
            {
                srRequest_Out = _srReqestListClient.EDC_spcGet_spcSR_spcList(srRequest_In);

                foreach (var sr in srRequest_Out.ListOf_ServiceRequest)
                {
                    srRequestList.Add(new ServiceRequestModel
                    {
                        SRNumber = sr.SRNumber,
                        Status = sr.Status,
                        Type = sr.Type,
                        Summary = sr.Summary
                    });
                }
            }
            catch
            {
                return srRequestList;
            }
            return srRequestList;
        }

        public List<ServiceRequestActivityModel> GetServiceRequestActivity(string srNumber)
        {
            List<ServiceRequestActivityModel> activity = new List<ServiceRequestActivityModel>();

            var srActivity_In = new SiebelReferenceAll.EDC_spcGet_spcSR_spcActivities_Input();
            var srActivity_out = new SiebelReferenceAll.EDC_spcGet_spcSR_spcActivities_Output();

            srActivity_In.ServiceRequestNumber = srNumber;

            try
            {
                srActivity_out = _srRequestActivityClient.EDC_spcGet_spcSR_spcActivities(srActivity_In);

                foreach (var sr in srActivity_out.ListOf_ServiceRequest)
                {
                    foreach (var ac in sr.ListOf_Activity)
                    {
                        activity.Add(new ServiceRequestActivityModel
                        {
                            SRNumber = sr.SRNumber,
                            Description = ac.Description,
                            Priority = ac.Priority,
                            Status = ac.Status,
                            Type = ac.Type
                        });
                    }
                }
            }
            catch
            {
                return activity;
            }
            return activity;
        }

        public bool Delete(ServiceRequestModel request)
        {
            throw new NotImplementedException();
        }

        public List<ServiceRequestModel> GetDetail(string customerId)
        {
            List<ServiceRequestModel> requestDetails = new List<ServiceRequestModel>();
            return requestDetails;
        }


        public ServiceRequestModel Update(ServiceRequestModel request)
        {
            throw new NotImplementedException();
        }
    }
}
