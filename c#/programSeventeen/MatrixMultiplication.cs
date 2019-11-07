using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Matrix Multiplication Using Rectanglular Array.");

            try
            {
                Console.WriteLine("Enter Rows and Column in 1st Matrix : ");
                int r1 = Convert.ToInt16(Console.ReadLine());
                int c1 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter Rows and Column in 2nd Matrix : ");
                int r2 = Convert.ToInt16(Console.ReadLine());
                int c2 = Convert.ToInt16(Console.ReadLine());

                if (r1 != c2)
                {
                    Console.WriteLine("Matrix Multiplication Row Column Rule Violated.");
                }
                else
                {
                    int[,] mat1 = new int[r1, c1];
                    int[,] mat2 = new int[r2, c2];
                    int[,] mat3 = new int[r1, c2];

                    Console.WriteLine("Enter Element in Matrix one : ");
                    for (int i = 0; i < r1; i++)
                    {
                        for (int j = 0; j < c1; j++)
                        {
                            mat1[i, j] = (Convert.ToInt16(Console.ReadLine()));
                        }
                    }
                    Console.WriteLine("Enter Element in Matrix two : ");
                    for (int i = 0; i < r2; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            mat2[i, j] = (Convert.ToInt16(Console.ReadLine()));
                        }
                    }
                    Console.WriteLine("\nFirst Matrix\n");
                    for (int i = 0; i < r1; i++)
                    {
                        for (int j = 0; j < c1; j++)
                        {
                            Console.Write("\t" + mat1[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nSecond Matrix\n");
                    for (int i = 0; i < r2; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            Console.Write("\t" + mat2[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nMultiplication of Matrix\n");
                    for (int i = 0; i < r1; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            for (int k = 0; k < c1; k++)
                            {
                                mat3[i, j] += mat1[i, k] * mat2[k, j];
                            }
                        }
                    }
                    for (int i = 0; i < r2; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            Console.Write("\t" + mat3[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n****************************");
                Console.WriteLine("Please Enter Numaric value.");
                Console.WriteLine("\n****************************");
            }
            Console.ReadKey();

        }
    }
}
