using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* Calcular la distancia entre 2 puntos en la recta numérica dados cada uno de 
             los puntos en unidades lineales, donde la distancia está dada por: d = |x2 - x1| */

            // declaracion de variables
            double num1, num2;
            double distancia;

            // entrada de datos
            Console.Write("Ingrese el valor del primer punto: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor del segundo punto: ");
            num2 = double.Parse(Console.ReadLine());

            // proceso de datos
            distancia = Math.Abs(num1 - num2);

            // salida de datos
            Console.WriteLine("La distancia entre estos puntos es: {0}", distancia);
            Console.ReadKey();
        }
    }
}
