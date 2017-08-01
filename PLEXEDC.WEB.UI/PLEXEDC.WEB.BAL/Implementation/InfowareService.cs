using System;
using System.Collections.Generic;
using PLEXEDC.WEB.INFOWARE.DAL.Model;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Web;

namespace PLEXEDC.WEB.BAL.Implementation
{
    public class InfowareService
    {
        public InfowareService()
        {

        }
        public List<CSCSNumber> GetCSCSNumber(string inforwareId)
        {
            //string jsonString = System.IO.File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/CSCSNumbers.json"));
            var webCient = new WebClient();
            string jsonString = webCient.DownloadString("http://www.dotnetperls.com/");
            JObject obj = JObject.Parse(jsonString);

            JToken row = obj["DataTable"]["Rows"];

            List<CSCSNumber> cscsNumber = new List<CSCSNumber>();
            if (row is JArray)
            {
                foreach (var value in row.Children<JToken>())
                {
                    cscsNumber.Add(new CSCSNumber
                    {
                        CsCsAcct = value.First["Value"].ToString(),
                        CsCsReg = value[1]["Value"].ToString(),
                        CSCSName = value[2]["Value"].ToString(),

                    });

                }
            }
            return cscsNumber;
        }
    }
}
