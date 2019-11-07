using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLineArgs
{
    class Program
    {
        static void Main(string[] args)
        {  
            try
            {
                if (args.Length >= 2)
                {
                    int num1 = Int32.Parse(args[0]);
                    int num2 = Int32.Parse(args[1]);
                    int sum = num1 + num2;

                    Console.WriteLine("CommandLine Args : " + num1 + " and " + num2);
                    Console.WriteLine("\nAddition of Command Line Args : {0}", sum);
                }
                else
                {
                    Console.WriteLine("No Command Line Args Passed.");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Invalid Args Passwd");
            }
            Console.ReadKey();
        }
    }
}


