using Microsoft.EntityFrameworkCore;
using SampleAPI.Models;

namespace EmployeeAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
