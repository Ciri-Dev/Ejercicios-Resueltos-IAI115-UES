using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    internal class Program
    {
        /* 25- Diseñe una solución que dado un número entre 1 y 11 despliegue si el 
         * número es primo o no.
         */

        static void Main(string[] args)
        {   
            // declaracion de variables
            int numero;

            // entrada de datos
            numero = LeerEntero("Ingrese un número entre 1 y 11: ");
            
            // proceso y salida de datos
            if (EsPrimo(numero))
                Console.WriteLine("\nEl número es primo.");
            else
                Console.WriteLine("\nEl número NO es primo.");
            Console.ReadKey();
        }

        /// <summary>
        /// Lee un número entero desde consola.
        /// </summary>
        static int LeerEntero(string mensaje)
        {
            Console.Write(mensaje);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Determina si un número entre 1 y 11 es primo.
        /// </summary>
        static bool EsPrimo(int numero)
        {
            // Validación del rango
            if (numero < 1 || numero > 11)
            {
                Console.WriteLine("Número fuera del rango permitido (1-11).");
                return false;
            }

            // Evaluación directa para números entre 1 y 11
            return numero == 2 || numero == 3 || numero == 5 || numero == 7 || numero == 11;
        }
    }
}
