using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2- Calcular la distancia entre 2 puntos en el plano dadas las coordenadas
             * x,y de cada uno*/

            // declaracion de variables
            double x1, y1, x2, y2;
            double p1, p2;
            double distancia;

            Console.WriteLine("Ingrese el valor de x del primer intervalo: ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y del primer intervalo: ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de x del segundo intervalo: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y del segundo intervalo: ");
            y2 = double.Parse(Console.ReadLine());

            // proceso de datos
            p1 = Math.Pow((x2 - x1), 2);
            p2 = Math.Pow((y2 - y1), 2);
            distancia = Math.Sqrt(p1 + p2);

            // salida de datos
            Console.WriteLine("La distancia entre estos 2 puntos es: {0:####.##}", distancia);
            Console.ReadLine();
        }
    }
}
