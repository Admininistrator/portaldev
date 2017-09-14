using PLEXEDC.WEB.DAL.Models;
using System.Collections.Generic;

namespace PLEXEDC.WEB.UI.Models
{
    public class TradeViewModel
    {
        public List<OpenOrder> OpenOrder { get; set; }
        public List<TradableStock> TradableStock { get; set; }

       // public List<OpenOrder> OpenOrder { get; set; }
    }
    
}