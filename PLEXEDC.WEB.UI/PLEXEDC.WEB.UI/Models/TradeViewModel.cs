using PLEXEDC.WEB.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PLEXEDC.WEB.UI.Models
{
    public class TradeViewModel
    {
        public List<OpenOrder> OpenOrder { get; set; }
        public List<TradableStock> TradableStock { get; set; }

       // public List<OpenOrder> OpenOrder { get; set; }
    }
    
}