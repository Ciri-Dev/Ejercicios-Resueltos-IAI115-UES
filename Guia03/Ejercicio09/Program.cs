using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 9- Dado el valor del radio de una esfera y una cadena con la abreviatura
             * de la unidad de medida, calcular y desplegar el volumen de la esfera con
             * sus unidades respectivas. La salida deberá ser como por ejemplo: 3.14 cm^3*/

            // declaracion de variables
            double radio, volumen;
            string unidad;

            // entrada de datos
            Console.Write("Ingrese el valor del radio: ");
            radio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la unidad de medida: ");
            unidad = Console.ReadLine();

            // proceso de datos
            volumen = 4 * Math.PI * Math.Pow(radio, 3) / 3;

            // salida de datos
            Console.WriteLine("El volumen de la esfera es: {0:####.##} {1}³", volumen, unidad);
            Console.ReadKey();
        }
    }
}
