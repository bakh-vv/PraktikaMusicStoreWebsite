//using AspNet.Identity.MySQL;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace PraktikaMusicStoreWebsite.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

    }

    //[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<PraktikaMusicStoreWebsite.Models.Feedback> Feedbacks { get; set; }
    }
}