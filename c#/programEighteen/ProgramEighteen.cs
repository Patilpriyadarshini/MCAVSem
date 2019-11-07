using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Hello: Base Class!");
            Console.Write("\nPress Enter...");
            Console.ReadLine();
        }
    }

    class B : A
    {
        public override void show()
        {
            Console.WriteLine("Hello: Derived Class!");
            Console.Write("\nPress Enter...");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use of Virtual and Overide Keyword.");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\nClass A is Base Class & Class B is derived from A.\n");
            Console.WriteLine("Creating Object of Class A.");
            A a1 = new A();
            a1.show();
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("Creating Object of Class B.");
            B b1 = new B();
            b1.show();
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("Creating Object of Class A & Calling Method of Class B.");
            A a2 = new B();
            a2.show();

            Console.ReadKey();
        }
    }
}










