using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is my amazing codebase.
            // How amazing can it be tho?
            double pi = 0;
            double e = 0;
            for (int i = 0; i < 1000*1000; i++)
            {
                pi += (i % 2 == 0 ? 4d : -4d) / (2 * i + 1);
                var add = 1 / Factorial(i);
                if(add > 0 && !double.IsNaN(add) && !double.IsInfinity(add))
                    e += add;
                Console.WriteLine("PI Approx = " + pi + ", e Approx = " + e);
                // I like pie...
                // Cake is better
            }

            Console.ReadKey();
        }
        static double Factorial(int n)
        {
            double factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;
            return factorial;
        }
    }
}
