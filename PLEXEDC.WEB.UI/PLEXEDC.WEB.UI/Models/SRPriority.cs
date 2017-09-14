using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PLEXEDC.WEB.UI.Models
{
    public class SRPriority
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

       
        public string Description { get; set; }
    }
}