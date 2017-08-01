using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.UI.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUserManager : IdentityUser
    {
        public string SiebelId { get; set; }
       
        public string CalypsoId { get; set; }

        public string InfowareId { get; set; }

        public string SessionId { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUserManager>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public  DbSet<Person> Person { get; set; }
    }
}