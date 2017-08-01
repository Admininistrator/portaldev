using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.INFOWARE.DAL.Model
{
    public class OpenOrder
    {
        public string StockCode { get; set; }
        public string Name { get; set; }
        public string TxnType { get; set; }
        public string Qty { get; set; }
        public string OrderDate { get; set; }
        public string QuotePrice { get; set; }
        public string LimitPrice { get; set; }
        public string InTheMkt { get; set; }
        public string ID { get; set; }
    }
}
