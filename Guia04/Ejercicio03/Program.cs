using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* 3- Escribir un programa, que permita convertir una cantidad en pies 
             * y las convierta a metros y convertir metros a centímetros */

            // declaracion de variables
            double pies, metros, centimetros;

            // entrada de datos
            Console.Write("\nIngrese una cantidad en pies: ");
            pies = Convert.ToDouble(Console.ReadLine());

            // proceso de datos
            metros = 0.3048 * pies;
            centimetros = metros * 100;

            // salida de datos
            Console.WriteLine($"{pies} pies son {metros:F2} metros y {centimetros:F2} centimetros.");
            Console.ReadKey();
        }
    }
}
