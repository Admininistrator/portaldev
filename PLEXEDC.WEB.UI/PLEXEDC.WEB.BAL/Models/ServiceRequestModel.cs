using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.BAL.Models
{
    public class ServiceRequestModel : BaseModel
    {
        public string Area { get; set; }
        public string ContactId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string SubArea { get; set; }
        public string Type { get; set; }
    }
}
