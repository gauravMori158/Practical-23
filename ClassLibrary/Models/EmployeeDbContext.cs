using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>option):base(option)
        {
                
        }
        public EmployeeDbContext()
        {
                
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = @"Data Source=sf-cpu-032\SQLEXPRESS;Initial Catalog=Practical23;Integrated Security=True;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }


    }
}
