using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPattern
{
    class Program
    {
        public static void printTrianglePattern()
        {
            Console.WriteLine("Provide height for triangle -");
            int triangleHeight = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= triangleHeight; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        public static void printSquareNumberPattern1()
        {
            Console.WriteLine("Enter no of rows -");
            int squareRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns -");
            int squareColumns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n");

            for (int i = 1; i <= squareRows; i++)
            {
                for (int j = 1; j <= squareColumns; j++)
                {
                    Console.Write("1");
                }
                Console.WriteLine("\n");
            }
        }

        public static void printSquareNumberPattern2()
        {
            Console.WriteLine("Enter no of rows -");
            int squareRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns -");
            int squareColumns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n");

            for (int i = 1; i <= squareRows; i++)
            {
                //Console.Write(i);
                for (int j = 1; j <= squareColumns; j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        public static void printSquareNumberPattern3()
        {
            Console.WriteLine("Enter no of rows -");
            int squareRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns -");
            int squareColumns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n");

            for (int i = 1; i <= squareRows; i++)
            {
                for (int j = 1; j <= squareColumns; j++)
                {
                    if (j % 2 == 1)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        public static void printSquareNumberPattern4()
        {
            Console.WriteLine("Enter no of rows -");
            int squareRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns -");
            int squareColumns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n");

            for (int i = 1; i <= squareRows; i++)
            {
                for (int j = 1; j <= squareColumns; j++)
                {
                    if (i == 1 || i == squareRows || j == 1 || j == squareColumns)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine("\n");
            }
        }


        static void Main(string[] args)
        {
            Program.printTrianglePattern();
            Program.printSquareNumberPattern1();
            Program.printSquareNumberPattern2();
            Program.printSquareNumberPattern3();
            Program.printSquareNumberPattern4();

            Console.ReadKey();
        }
    }
}
