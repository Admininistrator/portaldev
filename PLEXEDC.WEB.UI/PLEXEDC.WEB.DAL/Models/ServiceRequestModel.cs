﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.DAL.Models
{
    public class ServiceRequestModel : BaseModel
    {
        public string Area { get; set; }
        //public string ContactId { get; set; }
        public string CitizenId { get; set; }
        // public string Description { get; set; }
        public string ClosureComments { get; set; }
        public string Priority { get; set; }
        public string SRNumber { get; set; }
        public string Status { get; set; }
        public string SubStatus { get; set; }
        public string SubArea { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }

        public string Source { get; set; }
    }
}
