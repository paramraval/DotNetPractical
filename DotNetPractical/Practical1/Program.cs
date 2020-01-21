using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical1
{
    class Program
    {
        static void pattern1()
        {
            for (int i=1; i<=5; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void pattern2()
        {
            for (int i=1; i<=5; i++)
            {
                for (int j=5; j>=i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void pattern3()
        {
             for (int i=1; i<=5; i++)
             {
                for (int j=1; j<=5; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void pattern4()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i < j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void pattern5()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if ()
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            pattern1();
            pattern2();
            pattern3();
            pattern4();
            pattern5();
            Console.ReadLine();
        }
    }    
}
