using System.ComponentModel.DataAnnotations;

namespace Factory_Design_Pattern.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string EmailId { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool Status { get; set; }

        public Department Department { get; set; }
    }
}
