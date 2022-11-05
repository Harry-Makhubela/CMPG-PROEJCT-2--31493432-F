

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

namespace Project_2.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Project_2.Models.Zone> Zone { get; set; }
        public DbSet<Project_2.Models.Device> Device { get; set; }
        public DbSet<Project_2.Models.Category> Category { get; set; }



    }
}


