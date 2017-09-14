using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.DAL.Models
{
    public class BaseModel
    {
        //public string CustomerId { get; set; }

        public string SiebelId { get; set; }
        public string InfowareId { get; set; }
        public string CalypsoId { get; set; }
        public DateTime LastLoginDate { get; set; }

    }
}
