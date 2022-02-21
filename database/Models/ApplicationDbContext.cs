
using Microsoft.EntityFrameworkCore;
namespace database.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
