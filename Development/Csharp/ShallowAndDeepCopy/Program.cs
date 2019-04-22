using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopy
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public clsRefSalary EmpSalary;

        public Employee CreateShallowCopy(Employee emp)
        {
            return (Employee)emp.MemberwiseClone();
        }
    }

    public class clsRefSalary
    {
        // public string salaryOrg;
        public clsRefSalary(int _salary)
        {
            Salary = _salary;
        }
        public int Salary;
    }
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpId = 20;
            emp.EmpName = "Rohit";

            clsRefSalary clsref = new clsRefSalary(1000);
            emp.EmpSalary = clsref;

            Console.WriteLine("Before");
            Console.WriteLine("\nEmpId= {0}\nEmpName = {1}\nEmpSalary = {2}", emp.EmpId, emp.EmpName, emp.EmpSalary.Salary);
            Employee emp1 = emp.CreateShallowCopy(emp);
            Console.WriteLine("\nEmpId= {0}\nEmpName = {1}\nEmpSalary = {2}", emp1.EmpId, emp1.EmpName, emp1.EmpSalary.Salary);

            Console.WriteLine("\nAfter Changing value of ref type");
            emp1.EmpName = "Bhushan";
            emp1.EmpSalary.Salary = 2000;

            Console.WriteLine("\nEmpId= {0}\nEmpName = {1}\nEmpSalary = {2}", emp.EmpId, emp.EmpName, emp.EmpSalary.Salary);
            Console.WriteLine("\nEmpId= {0}\nEmpName = {1}\nEmpSalary = {2}", emp1.EmpId, emp1.EmpName, emp1.EmpSalary.Salary);
            Console.ReadKey();
        }
    }
}
