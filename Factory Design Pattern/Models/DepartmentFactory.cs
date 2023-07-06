namespace Factory_Design_Pattern.Models
{
    public abstract class Departments
    {
        public abstract decimal CalculateOvertimePay(int hoursWorked);
    }
    public class ITDepartment : Departments
    {
        public override decimal CalculateOvertimePay(int hoursWorked)
        {
            decimal departmentPay = 200; 
            return hoursWorked * departmentPay;
        }
    }
    public class HRDepartment : Departments
    {
        public override decimal CalculateOvertimePay(int hoursWorked)
        {
            decimal departmentPay = 150; 
            return hoursWorked * departmentPay;
        }
    }
    public class SalesDepartment : Departments
    {
        public override decimal CalculateOvertimePay(int hoursWorked)
        {
            decimal departmentPay = 100;
            return hoursWorked * departmentPay;
        }
    }
    public abstract class DepartmentFactory
    {
        public abstract Departments CreateDepartment();
    }

    public class IndoorFactory : DepartmentFactory
    {
        public override Departments CreateDepartment()
        {
            return new ITDepartment();
        }
    }
    public class OutdoorFactory : DepartmentFactory
    {
        public override Departments CreateDepartment()
        {
            return new SalesDepartment(); 
        }
    }


}
