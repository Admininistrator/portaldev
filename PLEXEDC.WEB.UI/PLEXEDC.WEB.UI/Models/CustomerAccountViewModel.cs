using PLEXEDC.WEB.DAL.Models;
using System.Collections.Generic;


namespace PLEXEDC.WEB.UI.Models
{
    public class CustomerAccountViewModel : BaseModel
    {
        public string AccountNumber { get; set; }
        public List<StockList> StockListing { get; set; }
        public List<Transaction> TransactionListing { get; set; }
    }
}