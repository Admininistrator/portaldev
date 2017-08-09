
using PLEXEDC.WEB.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PLEXEDC.WEB.UI.Models
{
    public class CustomerAccountViewModel : BaseModel
    {
        public string AccountNumber { get; set; }
        public List<StockList> StockListing { get; set; }
        public List<Transaction> TransactionListing { get; set; }
    }
}