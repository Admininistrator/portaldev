using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.DAL.Models
{
   public class ServiceRequestActivityModel
    {
        public string SRNumber { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }
}
