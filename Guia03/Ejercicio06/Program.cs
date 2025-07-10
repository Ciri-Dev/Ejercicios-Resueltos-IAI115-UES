using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6- Diseñar un programa que lea cuatro números, y calcule la suma de 
             * los dos primeros y el producto del tercero y el cuarto.*/

            // declaracion de variables
            double numero1, numero2, numero3, numero4;
            double suma, producto;

            // entrada de datos
            Console.Write("Ingrese el primer numero: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            numero3 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el cuarto numero: ");
            numero4 = double.Parse(Console.ReadLine());

            // proceso de datos
            suma = numero1 + numero2;
            producto = numero3 * numero4;

            // salida de datos
            Console.WriteLine("La suma de los dos primeros numeros es: " + suma);
            Console.WriteLine("El producto de los dos ultimos numeros es: " + producto);
            Console.ReadKey();
        }
    }
}
