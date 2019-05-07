using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDeserialization
{
    [Serializable]
    public class Employee
    {
        public int EmpId;
        public string EmpName;
        public string EmpAddress;
        public string Gender;
        public string DepartmentId;
    }
}
