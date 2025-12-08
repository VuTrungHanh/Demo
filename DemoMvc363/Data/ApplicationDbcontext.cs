using Microsoft.EntityFrameworkCore;
using DemoMvc363.Models;


namespace DemoMvc363.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<DemoMvc363.Models.Employee> Employee { get; set; } = default!;
    }
}
