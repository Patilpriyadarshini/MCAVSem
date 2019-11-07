using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication37
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                Console.WriteLine("Enter 5 element in array : ");
                for (int i = 0; i < 5; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("---------------------");
                Array.Sort(arr);
                Array.Reverse(arr);
                Console.WriteLine("Sorted Array in Reverce Order");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("A[" + i + "] = " + arr[i]);
                }
                Console.WriteLine("Second Largest Value in Array : " + arr[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Provide Valid Array Element.\nOnly Numeric Values are allowed.");
            }
            Console.ReadKey();
        }
    }
}
