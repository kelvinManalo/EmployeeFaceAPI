using Microsoft.EntityFrameworkCore;

namespace EmployeeFace.DataAccess.Model
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
