using System.ComponentModel.DataAnnotations;

namespace Factory_Design_Pattern.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set;}

        public int DepartmentPay { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }
}
