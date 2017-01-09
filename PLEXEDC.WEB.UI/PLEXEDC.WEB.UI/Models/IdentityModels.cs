using Microsoft.AspNet.Identity.EntityFramework;

namespace PLEXEDC.WEB.UI.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string SiebelId { get; set; }
       
        public string CalypsoId { get; set; }

        public string InfowareId { get; set; }

        public string SessionId { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}