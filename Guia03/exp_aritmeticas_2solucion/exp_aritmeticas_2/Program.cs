using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp_aritmeticas_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /* 2- En cada literal evalue ambas expresiones y compare los 
             resultados obtenidos. */
            // a)
            int y1 = 7 % 5 % 3;
            int y2 = 7 % (5 % 3);
            // b)
            int x1 = (7 % 5) % 3;
            int x2 = 7 % 5 % 3;
            // c)
            int a1 = 7 * 10 - 5 % 3 * 4 + (int)Math.Pow(9, 2);
            int a2 = (7 * 10 - 5 % 3 * 4) + (int)Math.Pow(9, 2);

            Console.WriteLine($"y1 = {y1}");
            Console.WriteLine($"y2 = {y2}");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
            Console.WriteLine($"a1 = {a1}");
            Console.WriteLine($"a2 = {a2}");

            Console.ReadKey();
        }
    }
}
