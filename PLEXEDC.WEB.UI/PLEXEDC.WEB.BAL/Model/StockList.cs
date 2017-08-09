using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.BAL.Model
{
    public class StockList
    {
        public string Symbol { get; set; }
        public string Qty { get; set; }
        public string MostRecentPrice { get; set; }
        public string MktValue { get; set; }
        public string CostBasis { get; set; }
        public string Chg { get; set; }
        public string ChgSincePurchase { get; set; }
    }
}
