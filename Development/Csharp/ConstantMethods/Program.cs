using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class abstractclass
    {

        public virtual int addNumber(int i, int j)
        {
            return i + j;
        }
    }


    class Program : abstractclass
    {
        public int Add(int i, int j)
        {
            return i + j;
        }

        public override int addNumber(int i, int j)
        {
            return i + j;
        }

        static void Main(string[] args)
        {

            Program p = new Program();
            int sum = p.addNumber(1, 2);
            Console.WriteLine("sum is = {0}", sum);

            int summ = p.Add(2, 2);
            Console.WriteLine("sum is = {0}", summ);

            Console.ReadKey();

        }
    }
}
