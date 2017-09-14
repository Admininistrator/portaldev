using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

using PLEXEDC.WEB.BAL.Core;
using PLEXEDC.WEB.DAL.Models;

namespace PLEXEDC.WEB.BAL.Implementation
{
    public class InfowareService : IInfowareService
    {
        public InfowareService()
        {

        }
        public List<CSCSNumber> GetCSCSNumber(string sessionId, string inforwareId)
        {
            List<CSCSNumber> cscsNumber = new List<CSCSNumber>();
            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/CustInfo/";
            url += sessionId + "/" + inforwareId + "/1";
            var client = new HttpClient();
            try
            {

                string jsonString = client.GetStringAsync(url).Result;
                JObject obj = JObject.Parse(jsonString);
                JToken row = obj["DataTable"]["Rows"];
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
            }
            catch
            {
                return cscsNumber;
            }
            return cscsNumber;
        }

        public List<StockList> GetPortFolio(string sessionId, string inforwareId)
        {
            List<StockList> stockList = new List<StockList>();
            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/CustInfo/";
            url += sessionId + "/" + inforwareId + "/7";
            var client = new HttpClient();

            try
            {
                string jsonString = client.GetStringAsync(url).Result;
                JObject obj = JObject.Parse(jsonString);
                JToken row = obj["DataTable"]["Rows"];

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
            }
            catch
            {
                return stockList;
            }
            return stockList;
        }

        public List<Transaction> GetAccountOverView(string sessionId, string inforwareId)
        {
            List<Transaction> accountOverView = new List<Transaction>();
            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/PGetData2/";
            url += sessionId + "/?FID=P_00001&P=" + inforwareId;
            var client = new HttpClient();

            try
            {
                string jsonString = client.GetStringAsync(url).Result;
                JObject obj = JObject.Parse(jsonString);
                JToken row = obj["DataTable"]["Rows"];
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
            }
            catch
            {
                return accountOverView;
            }
            return accountOverView;
        }

        public List<OpenOrder> GetOpenOrder(string sessionId, string inforwareId)
        {
            List<OpenOrder> openOrder = new List<OpenOrder>();
            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/CustInfo/";
            url += sessionId + "/" + inforwareId + "/2";
            var client = new HttpClient();

            try
            {
                string jsonString = client.GetStringAsync(url).Result;
                JObject obj = JObject.Parse(jsonString);
                JToken row = obj["DataTable"]["Rows"];
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
            }
            catch
            {
                return openOrder;
            }
            return openOrder;
        }

        public List<TradableStock> GetTradableStock(string sessionId, string inforwareId)
        {
            List<TradableStock> tradableStock = new List<TradableStock>();
            string url = "http://192.168.2.27/IWAPISvcs/IWAPISvcs.svc/api/json/CustInfo/";
            url += sessionId + "/" + inforwareId + "/7";
            var client = new HttpClient();
            try
            {
                string jsonString = client.GetStringAsync(url).Result;
                JObject obj = JObject.Parse(jsonString);
                JToken row = obj["DataTable"]["Rows"];
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
            }
            catch
            {
                return tradableStock;
            }
            return tradableStock;
        }
    }
}
