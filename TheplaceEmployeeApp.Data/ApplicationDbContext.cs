using TheplaceEmployeeApp.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace TheplaceEmployeeApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //using code first Approach
        public DbSet<Employee> Employees { get; set; }
    }
}
