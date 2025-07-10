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
            /* 8- Calcular y mostrar la distancia entre dos puntos de una recta, dado el 
             * valor de 2 puntos ingresados por teclado y dada una cadena de caracteres 
             * ingresada por teclado, conteniendo la abreviatura de la unidad de medida; 
             * donde la distancia está dada por:  d = |x2 - x1|   La salida deberá ser 
             * como por ejemplo: 10 cm*/

            // declaracion de variables
            int punto1, punto2, distancia;
            string unidad;

            // entrada de datos
            Console.Write("Ingrese el valor del primer punto: ");
            punto1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del segundo punto: ");
            punto2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la unidad metrica: ");
            unidad = Console.ReadLine();

            // proceso de datos
            distancia = Math.Abs(punto1 - punto2);

            // salida de datos
            Console.WriteLine("La distancia entre estos dos puntos es: {0} {1}", distancia, unidad);
            Console.ReadKey();
        }
    }
}
