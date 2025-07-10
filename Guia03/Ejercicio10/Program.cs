using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10- Dada la longitud del lado de un cubo y una cadena conteniendo la 
             * abreviatura de la  unidad de medida de dicha longitud, calcular y 
             * desplegar el volumen del cubo. La salida deberá ser como 
             * por ejemplo: 8 mt^3*/

            // declaracion de variables
            double lado, volumen;
            string unidad;

            // entrada de datos
            Console.Write("Ingrese el lado del cubo: ");
            lado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la unidad de medida: ");
            unidad = Console.ReadLine();

            // proceso
            volumen = Math.Pow(lado, 3);

            // salida de datos
            Console.WriteLine("El volumen del cubo es: {0:####.##} {1}³", volumen, unidad);
            Console.ReadKey();
        }
    }
}
