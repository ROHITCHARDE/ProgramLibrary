using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsAndClasses
{
    public class A
    {
        public A()
        {
            Console.WriteLine("Hello normal A");
        }
        static A()
        {
            Console.WriteLine("Hello static A");
        }

    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("\n Hello normal B");
        }
        static B()
        {
            Console.WriteLine("\n Hello static B");
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("\n\n");
            B b = new B();
            Console.WriteLine("\n\n");
            A c = new B();
            Console.WriteLine("\n\n");
           // B d = (A)new A();

        }
    }
}
