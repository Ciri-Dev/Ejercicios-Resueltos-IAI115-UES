using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* 5- Convertir una temperatura en grados Fahrenheit a Celsius utilizando
             * las siguiente fórmula: °F = °C × 9/5 + 32*/

            // declaracion de variables
            double fahreinheit, celsius;

            // entrada de datos
            Console.Write("Ingrese la temperatura en grados Fahreinheit: ");
            fahreinheit = Convert.ToDouble(Console.ReadLine());

            // proceso de datos
            celsius = (fahreinheit - 32) * 5 / 9;

            // salida de datos
            Console.WriteLine("\nLa temperatura en grados Celsius es: {0:####.##} grados", celsius);
            Console.ReadKey();
        }
    }
}
