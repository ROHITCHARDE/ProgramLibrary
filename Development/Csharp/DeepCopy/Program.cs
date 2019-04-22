using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    [Serializable]
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public ClsRefSalary EmpSalary;

        public Employee CreateDeepCopy(Employee emp)
        {
            MemoryStream m = new MemoryStream();
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(m, emp);
            m.Position = 0;
            return (Employee)b.Deserialize(m);
        }
    }

    [Serializable]
    class ClsRefSalary
    {
        public ClsRefSalary(int _salary)
        {
            Salary = _salary;
        }
        public int Salary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.EmpId = 1000;
            emp.EmpName = "Rohit";
            ClsRefSalary refSalary = new ClsRefSalary(100000);
            emp.EmpSalary = refSalary;
            Console.Write("Before");
            Console.WriteLine("\nEmpId = {0}\nEmpName = {1}\nEmpSalary = {2} ", emp.EmpId, emp.EmpName, emp.EmpSalary.Salary);

            Employee emp1 = emp.CreateDeepCopy(emp);
            Console.WriteLine("\nEmpId= {0}\nEmpName = {1}\nEmpSalary = {2}", emp1.EmpId, emp1.EmpName, emp1.EmpSalary.Salary);

            Console.WriteLine("\nAfter Changing value of ref type");
            emp1.EmpName = "Employee1";
            emp1.EmpSalary.Salary = 2000;

            Console.WriteLine("\nEmpId= {0}\nEmpName = {1}\nEmpSalary = {2}", emp.EmpId, emp.EmpName, emp.EmpSalary.Salary);
            Console.WriteLine("\nEmpId= {0}\nEmpName = {1}\nEmpSalary = {2}", emp1.EmpId, emp1.EmpName, emp1.EmpSalary.Salary);
            Console.ReadKey();
        }
    }
}
