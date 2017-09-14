using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PLEXEDC.WEB.UI.Models
{
    public class SRSubStatus
    {
        
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? SRStatusId { get; set; }

        public virtual SRStatus SRStatus { get; set; }
    }
}