using Microsoft.EntityFrameworkCore;

namespace Factory_Design_Pattern.Models
{
    public class BAL
    {
        private readonly EmployeeDbContext context;
        public BAL(EmployeeDbContext cont)
        {
                context= cont;
        }
        public void CreateEmployee(Employee employee)
        {
           
                context.Employees.Add(employee);
                context.SaveChanges();
             
        }

        public int GetOverTime (int hours , int EmpId)
        {
            var employee = context.Employees.Include(e => e.Department); 
            
            int Ot= employee.FirstOrDefault(e=>e.Id == EmpId).Department.DepartmentPay * hours;
            return Ot;
        }
        public List<Employee> GetEmployees()
        {
              var employees = context.Employees.Where(e=>e.Status == true).ToList();
                return employees;
            
            
        }
        public  Employee GetEmployeeById(int id)
        {
             
                return context.Employees.Where(e=>e.Status==true).FirstOrDefault(e=>e.Id == id);
             
        }
        public void DeleteEmployee(int id)
        {
             
                var employee = context.Employees.Find(id);
                employee.Status = false;
                //context.Employees.Remove(employee);
                context.SaveChanges();
            
        }

        public void UpdateEmployee(Employee employee)
        {
            
                context.Employees.Update(employee);
                context.SaveChanges();

             
        }

    }
}
