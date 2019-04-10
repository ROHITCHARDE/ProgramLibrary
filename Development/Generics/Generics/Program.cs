using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static T GenericAdd<T>(T num1, T num2)
        {
            dynamic no1 = num1;
            dynamic no2 = num2;

            return no1 + no2;
        }

        static void GenericPrint<T>(T result)
        {
            Console.WriteLine("Result is = {0}", result);
        }

        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 200;
            int result = GenericAdd<int>(num1, num2);
            GenericPrint(result);
            GenericPrint("Hello how are you");
            Console.ReadKey();
        }
    }
}
