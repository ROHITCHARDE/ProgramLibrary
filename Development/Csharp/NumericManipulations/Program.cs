using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericManipulations
{
    class Program
    {
        private static void AddNumber()
        {
            int acceptNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("accepted number is = {0}", acceptNumber);
            int sum = 0;

            while (acceptNumber > 0)
            {
                sum = sum + (acceptNumber % 10);
                acceptNumber = acceptNumber / 10;
            }
            Console.WriteLine("sum of number is = {0}", sum);
        }
       

        static void Main(string[] args)
        {
            AddNumber();
            Console.ReadKey();
        }
    }
}