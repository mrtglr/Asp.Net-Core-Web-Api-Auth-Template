using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Context
{
    public class ApplicationContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connecting to database with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("Connection"));
        }

        public DbSet<ApplicationUser> Users { get; set; }
        // Your db sets here...
    }
}
