using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data; //Contains DataTable


namespace SerializationDeserialization
{
    [Serializable]
    class Program
    {
        static string connectionString = @"Data Source=NIT-WKS-0047\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";

        static void getTableData()
        {
            DataTable table = new DataTable();
            List<Employee> emp = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sqlDaEmp = new SqlDataAdapter("Select * from Employee", con);
                sqlDaEmp.Fill(table);
            }
            foreach (DataRow dataRow in table.Rows)
            {
                Employee singleEmp = new Employee();
                singleEmp.EmpId = Convert.ToInt32(dataRow.ItemArray[0]);
                singleEmp.EmpName = Convert.ToString(dataRow.ItemArray[1]);
                singleEmp.EmpAddress = Convert.ToString(dataRow.ItemArray[2]);
                singleEmp.Gender = Convert.ToString(dataRow.ItemArray[3]);
                singleEmp.DepartmentId = Convert.ToString(dataRow.ItemArray[4]);
                emp.Add(singleEmp);
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"E:\File\Employee.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, emp);
            stream.Close();

            stream = new FileStream(@"E:\File\Employee.txt", FileMode.Open, FileAccess.Read);
            List<Employee> deEmployee = (List<Employee>)formatter.Deserialize(stream);



        }

        static void Main(string[] args)
        {
            getTableData();
            Console.ReadKey();
        }
    }
}
