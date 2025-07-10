using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* 4- Calcular el área de un cubo sabiendo que la fórmula es  
             * A=6 x aristas 2*/

            // declaracion de variables
            double aristas, area;

            Console.WriteLine("Ingrese el valor de las aristas: ");
            aristas = double.Parse(Console.ReadLine());

            // proceso de datos
            area = 6 * (Math.Pow(aristas, 2));

            // salida de datos
            Console.WriteLine("El area del cubo es: {0:####.##} cm²", area);
            Console.ReadKey();
        }
    }
}
