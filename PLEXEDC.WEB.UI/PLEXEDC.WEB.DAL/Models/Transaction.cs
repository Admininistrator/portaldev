using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.DAL.Models
{
    public class Transaction
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string AID { get; set; }
        public DateTime TxnDate { get; set; }
    }
}
