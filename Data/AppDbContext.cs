using Microsoft.EntityFrameworkCore;
using D1W3_AssignementCURD.Models;

namespace D1W3_AssignementCURD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
