using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PLEXEDC.WEB.UI.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string SiebelId { get; set; }

        public string CalypsoId { get; set; }

        public string InfowareId { get; set; }

        public string SessionId { get; set; }

        public string ApplicationUserId { get; set; }

        [Required]
        public DateTime LastLoginDate { get; set; }

        public virtual ApplicationUserManager ApplicationUser { get; set; }
    }
}