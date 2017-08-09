using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.BAL.Models
{
    public class ActivityModel
    {
        public string Type { get; set; }

        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
