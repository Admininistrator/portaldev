using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PLEXEDC.WEB.UI.Models
{
    public class SRArea
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int SRTypeId { get; set; }

        public virtual SRType SRType {get; set;}
    }
}