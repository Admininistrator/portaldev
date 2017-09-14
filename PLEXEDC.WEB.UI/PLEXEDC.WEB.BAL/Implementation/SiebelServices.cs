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
        public SiebelReference.EDC_spcSR_spcDetailsClient client;

        private XmlDocument xmlSource = new XmlDocument();

        public void SetClient(SiebelReference.EDC_spcSR_spcDetailsClient Client)
        {
            this.client = Client;
        }

        public SiebelServices()
        {
            xmlSource.Load(Path.Combine(HttpContext.Current.Server.MapPath("~/App_Data/EDC ServiceRequests.xml")));
            var client = new SiebelReference.EDC_spcSR_spcDetailsClient();

            SetClient(client);
        }

        public void Create(ServiceRequestModel request)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ServiceRequestModel request)
        {
            throw new NotImplementedException();
        }

        public List<ServiceRequestModel> GetDetail(string customerId)
        {
            //var model = new SiebelReference.EDC_spcSR_spcDetails_Input();
            //model.CustomerId = customerId;
            List<ServiceRequestModel> requestDetails = new List<ServiceRequestModel>();

            XmlNodeList list = xmlSource.GetElementsByTagName("con:mockOperation");
            XmlNode reponse = list[2].ChildNodes.Item(3);
            XmlNode xReseponseContent = reponse["con:responseContent"];
            XmlNode cdate = xReseponseContent.ChildNodes[0];
            XDocument xDoc = XDocument.Load(new StringReader(cdate.InnerText));

            var activityResponse = from element in xDoc.Descendants("ListOf_ServiceRequest")
                                   select element;

            foreach (var xelement in activityResponse.Descendants("ServiceRequest"))
            {
                requestDetails.Add(new ServiceRequestModel
                {
                    SRNumber = xelement.Element("SRNumber").Value,
                    Type = xelement.Element("Type").Value,
                    Status = xelement.Element("Status").Value,
                    Priority = xelement.Element("Priority").Value,
                    SubArea = xelement.Element("SubArea").Value,
                    SubStatus = xelement.Element("SubStatus").Value,
                    Summary = xelement.Element("Summary").Value,
                    ClosureComments = xelement.Element("ClosureComments").Value,
                    CitizenId = xelement.Element("CitizenId").Value,
                    Area = xelement.Element("Area").Value
                });
            }
            //if (client != null)
            //{ 
            //    requestDetails = client.EDC_spcSR_spcDetails(model).ListOf_ServiceRequest.Select(x => new ServiceRequestModel {
            //        Area = x.CitizenId,
            //        CitizenId = x.CitizenId,
            //        ClosureComment = x.ClosureComments,
            //        Priority = x.Priority,
            //        SRNumber = x.SRNumber,
            //        Status = x.Status,
            //        SubArea = x.SubArea,
            //        Summary = x.Summary,
            //        Type = x.Type
            //    }).ToList();
            //}

            return requestDetails;
        }

        public List<ServiceRequestActivityModel> GetActivity()
        {
            List<ServiceRequestActivityModel> activity = new List<ServiceRequestActivityModel>();
            XmlNodeList list = xmlSource.GetElementsByTagName("con:mockOperation");
            XmlNode reponse = list[0].ChildNodes.Item(3);
            XmlNode xReseponseContent = reponse["con:responseContent"];
            XmlNode cdate = xReseponseContent.ChildNodes[0];
            XDocument xDoc = XDocument.Load(new StringReader(cdate.InnerText));

            var activityResponse = from element in xDoc.Descendants("ServiceRequest")
                                   select element;

            foreach (var xelement in activityResponse)
            {
                foreach (var ac in xelement.Elements("ListOf_Activity").Elements("Activity"))
                {
                    activity.Add(new ServiceRequestActivityModel
                    {
                        SRNumber = xelement.Element("SRNumber").Value,
                        Type = ac.Element("Type").Value,
                        Status = ac.Element("Status").Value,
                        Description = ac.Element("Description").Value
                    });
                }
            }
            return activity;
        }

        public ServiceRequestModel Update(ServiceRequestModel request)
        {
            throw new NotImplementedException();
        }
    }
}
