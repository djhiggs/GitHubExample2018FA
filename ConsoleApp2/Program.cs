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
            double pi = 0;
            for (int i = 0; i < 1000*1000; i++)
            {
                pi += (i % 2 == 0 ? 4d : -4d) / (2 * i + 1);
                Console.WriteLine("PI Approx = " + pi);
            }
            Console.ReadKey();
        }
    }
}
