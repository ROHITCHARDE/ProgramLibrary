using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercises
{
    class Program
    {
        static void lengthOfString()
        {
            int count = 0;
            Console.WriteLine("Enter a string");
            string getString = Console.ReadLine();

            for (int lengthCount = 0; getString.Count() > lengthCount; lengthCount++)
            {
                count++;
            }
            Console.WriteLine("Length of string is - {0}", count);
        }

        static void copyString()
        {
            string getString = string.Empty;
            char[] StringCopy = new char[50];
            int lengthCount;

            Console.WriteLine("Enter a string");
            getString = Console.ReadLine();

            for (lengthCount = 0; getString.Count() > lengthCount; lengthCount++)
            {
                StringCopy[lengthCount] = getString[lengthCount];
            }
            Console.WriteLine("Length of string is - {0}", lengthCount);
            Console.WriteLine("Copied string is - {0}", StringCopy);
        }

        static void concatenateTwoString()
        {
            string getString = string.Empty;
            char[] StringCopy = new char[50];
            int lengthCount;

            Console.WriteLine("Enter a string");
            getString = Console.ReadLine();

            for (lengthCount = 0; getString.Count() > lengthCount; lengthCount++)
            {
                StringCopy[lengthCount] = getString[lengthCount];
            }
            Console.WriteLine("Length of string is - {0}", lengthCount);
            Console.WriteLine("Copied string is - {0}", StringCopy);
        }

        static void Main(string[] args)
        {
            lengthOfString();
            copyString();

            Console.ReadKey();
        }
    }
}
