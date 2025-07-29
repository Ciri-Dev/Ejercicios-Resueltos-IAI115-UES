using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {   /*
         7- Dado un número real calcule y muestre el cuadrado, cubo, cuarta y quinta 
         potencia del número. 
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            double numero, cuadrado, cubo, cuarta, quinta;
            
            // entrada de datos
            numero = LeerDouble("Ingrese un número real:");

            // proceso de datos
            cuadrado = CalcularPotencia(numero, 2);
            cubo = CalcularPotencia(numero, 3);
            cuarta = CalcularPotencia(numero, 4);
            quinta = CalcularPotencia(numero, 5);

            // salida de datos
            Console.WriteLine($"\nResultados para el número {numero}:");
            Console.WriteLine($"Cuadrado: {cuadrado}");
            Console.WriteLine($"Cubo: {cubo}");
            Console.WriteLine($"Cuarta potencia: {cuarta}");
            Console.WriteLine($"Quinta potencia: {quinta}");

            Console.ReadKey();
        }

        /// <summary>
        /// Muestra un mensaje al usuario, solicita un valor (double) por teclado 
        /// y lo retorna.
        /// </summary>
        static double LeerDouble(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calcula la potencia de una base elevada a un exponente.
        /// </summary>
        static double CalcularPotencia(double baseNum, int exponente)
        {
            return Math.Pow(baseNum, exponente);
        }
    }
}
