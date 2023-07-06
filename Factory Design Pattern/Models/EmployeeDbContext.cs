using Microsoft.EntityFrameworkCore;

namespace Factory_Design_Pattern.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>option):base(option)
        {
                
        }
      
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments{ get; set; }

       
    }
}
