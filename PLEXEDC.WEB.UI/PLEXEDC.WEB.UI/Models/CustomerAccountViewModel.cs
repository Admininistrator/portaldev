using PLEXEDC.WEB.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PLEXEDC.WEB.UI.Models
{
    public class CustomerAccountViewModel : BaseModel
    {
        public string PortfolioValue { get; set; }
        public List<string> Accounts { get; set; }
    }
}