using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8- Calcular y mostrar la altura de un triángulo equilátero dada la 
             * longitud del lado a, donde h es la altura. Suponer que la altura se 
             * calcula multiplicando la raíz cuadrada de 3 por el valor del lado a,
             * y este resultado, se divide entre 2. */

            // declaracion de variables
            double lado, altura;

            // entrada de datos
            Console.Write("Ingrese la longitud del lado del triangulo: ");
            lado = double.Parse(Console.ReadLine());

            // proceso de datos
            altura = Math.Sqrt(3) * lado / 2;

            // salida de datos
            Console.WriteLine($"La altura del triángulo es: {altura:F2}");
            Console.ReadKey();
        }
    }
}
