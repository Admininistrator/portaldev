using System;
using System.Collections.Generic;
using PLEXEDC.WEB.INFOWARE.DAL.Model;
using System.Web;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using PLEXEDC.WEB.BAL.Models;
using PLEXEDC.WEB.BAL.Model;
using PLEXEDC.WEB.BAL.Core;

namespace PLEXEDC.WEB.BAL.Implementation
{
    public class InfowareService: IInfowareService
    {
        public InfowareService()
        {

        }
        public List<CSCSNumber> GetCSCSNumber(string sessionId, string inforwareId)
        {

            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/CustInfo/";
            url +=sessionId+"/"+inforwareId+"/1";
            var client = new HttpClient();
             string jsonString = client.GetStringAsync(url).Result;
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

        public List<StockList> GetPortFolio(string sessionId, string inforwareId)
        {
            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/CustInfo/";
            url += sessionId + "/" + inforwareId + "/7";
            var client = new HttpClient();
            
            string jsonString = client.GetStringAsync(url).Result;
            
            JObject obj = JObject.Parse(jsonString);
            JToken row = obj["DataTable"]["Rows"];

            List<StockList> stockList = new List<StockList>();
            if (row is JArray)
            {
                foreach (var value in row.Children<JToken>())
                {

                    stockList.Add(new StockList
                    {
                        Symbol = value.First["Value"].ToString(),
                        Qty = value[1]["Value"].ToString(),
                        MostRecentPrice = value[2]["Value"].ToString(),
                        MktValue = value[3]["Value"].ToString(),
                        CostBasis = value[4]["Value"].ToString(),
                        Chg = value[5]["Value"].ToString(),
                        ChgSincePurchase = value[6]["Value"].ToString(),

                    });

                }

            }
            return stockList;
        }

        public List<Transaction> GetAccountOverView(string sessionId, string inforwareId)
        {
            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/PGetData2/";
            url += sessionId + "/?FID=P_00001&P=" + inforwareId;

            var client = new HttpClient();

            string jsonString = client.GetStringAsync(url).Result;

            JObject obj = JObject.Parse(jsonString);
            JToken row = obj["DataTable"]["Rows"];

            List<Transaction> accountOverView = new List<Transaction>();
            if (row is JArray)
            {
                foreach (var value in row.Children<JToken>())
                {

                    accountOverView.Add(new Transaction
                    {
                        Type = value.First["Value"].ToString(),
                        Description = value[1]["Value"].ToString(),
                        Status = value[2]["Value"].ToString(),
                        AID = value[3]["Value"].ToString(),
                        TxnDate = (DateTime)value[4]["Value"],
                    });

                }

            }
            return accountOverView;
        }

        public List<OpenOrder> GetOpenOrder(string sessionId, string inforwareId)
        {
            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/CustInfo/";
            url += sessionId + "/" + inforwareId + "/2";

            var client = new HttpClient();

            string jsonString = client.GetStringAsync(url).Result;

            JObject obj = JObject.Parse(jsonString);
            JToken row = obj["DataTable"]["Rows"];

            List<OpenOrder> openOrder = new List<OpenOrder>();
            if (row is JArray)
            {
                foreach (var value in row.Children<JToken>())
                {

                    openOrder.Add(new OpenOrder
                    {
                        StockCode = value.First["Value"].ToString(),
                        Name = value[1]["Value"].ToString(),
                        TxnType = value[2]["Value"].ToString(),
                        Qty = value[3]["Value"].ToString(),
                        OrderDate = (DateTime)value[4]["Value"],
                        QuotePrice = value[5]["Value"].ToString(),
                        LimitPrice = value[6]["Value"].ToString(),
                        InTheMkt = value[6]["Value"].ToString(),
                        ID = value[8]["Value"].ToString(),
                    });

                }

            }
            return openOrder;
        }

        public List<TradableStock> GetTradableStock(string sessionId, string inforwareId)
        {
            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/CustInfo/";
            url += sessionId + "/" + inforwareId + "/7";

            var client = new HttpClient();

            string jsonString = client.GetStringAsync(url).Result;

            JObject obj = JObject.Parse(jsonString);
            JToken row = obj["DataTable"]["Rows"];

            List<TradableStock> tradableStock = new List<TradableStock>();
            if (row is JArray)
            {
                foreach (var value in row.Children<JToken>())
                {

                    tradableStock.Add(new TradableStock
                    {
                        Symbol = value.First["Value"].ToString(),
                        Qty = value[1]["Value"].ToString(),
                        MostRecentPrice = value[2]["Value"].ToString(),
                        MktValue = value[3]["Value"].ToString(),
                        CostBasis = value[4]["Value"].ToString(),
                        Chg = value[5]["Value"].ToString(),
                        ChgSincePurchase = value[6]["Value"].ToString()
                    });

                }

            }
            return tradableStock;
        }
    }
}
