using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* 7- Leer dos números flotantes que corresponden a la longitud de los 
             * dos catetos de un triángulo rectángulo. Calcular y mostrar el valor 
             * de la hipotenusa y el perímetro del triángulo. */

            // declaracion de variables
            float cateto1, cateto2;
            double sumaCatetos, hipotenusa, perimetro;

            // entrada de datos
            Console.Write("Ingrese el valor del primer cateto: ");
            cateto1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del segundo cateto: ");
            cateto2 = float.Parse(Console.ReadLine());

            // proceso de datos
            sumaCatetos = Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
            hipotenusa = Math.Sqrt(sumaCatetos);
            perimetro = cateto1 + cateto2 + hipotenusa;

            // salida de datos
            Console.WriteLine("La medida de la hipotenusa es: {0:####.##}", hipotenusa);
            Console.WriteLine("La medida del perimetro es: {0:####.##}", perimetro);
            Console.ReadKey();
        }
    }
}
