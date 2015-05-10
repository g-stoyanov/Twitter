namespace TwitterSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using TwitterSystem.Data.Models;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
