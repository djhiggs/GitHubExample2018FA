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
            for (int i = 0; i < 1000*1000; i++)
            {
                pi += (i % 2 == 0 ? 4d : -4d) / (2 * i + 1);
                Console.WriteLine("PI Approx = " + pi);
                // I like pie...
                // Cake is better
                /*Did you ever hear the tragedy of Darth Plagueis The Wise? 
                 * I thought not. 
                 * It's not a story the Jedi would tell you. 
                 * It's a Sith legend. 
                 * Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life… 
                 * He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. 
                 * The dark side of the Force is a pathway to many abilities some consider to be unnatural. 
                 * He became so powerful… the only thing he was afraid of was losing his power, which eventually, of course, he did. 
                 * Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. 
                 * He could save others from death, but not himself.
                 */
            }
            Console.ReadKey();
        }
    }
}
