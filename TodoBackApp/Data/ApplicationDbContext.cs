
using Microsoft.EntityFrameworkCore;

namespace TodoBackApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Models.Task> Tasks { get; set; }
    }
}
