using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Year to check whether leap year or not : ");
                long year = Convert.ToInt64(Console.ReadLine());

                if (year % 400 == 0)
                {
                    Console.WriteLine("\t{0} is a Leap Year", year);
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine("\t{0} is not a Leap Year", year);
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine("\t{0} is a Leap Year", year);
                }
                else
                {
                    Console.WriteLine("\t{0} is not a Leap Year", year);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter valid year");
            }

            Console.ReadKey();
        }
    }
}
