using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.BAL.Models
{
    public class ServiceRequestModel : BaseModel
    {

        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public string Summary { get; set; }

        public string Area { get; set; }

        public string SubArea { get; set; }


        




    }
}
