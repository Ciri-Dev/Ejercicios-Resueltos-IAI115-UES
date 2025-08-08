using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    internal class Program
    {
        /*
         * 26- Diseñe una solución que dado un número, despliegue un mensaje si es 
         * par o es impar o es cero.
         */

        static void Main(string[] args)
        {   
            // declaracion de variables
            int numero;

            // entrada de datos
            numero = LeerEntero("Ingrese un número entero: ");

            // proceso y salida de datos
            if (numero == 0)
            {
                Console.WriteLine("\nEl número es CERO.");
            }
            else if (EsPar(numero))
            {
                Console.WriteLine("\nEl número es PAR.");
            }
            else
            {
                Console.WriteLine("\nEl número es IMPAR.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Determina si un número es par.
        /// </summary>
        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }

        /// <summary>
        /// Lee un número entero desde consola.
        /// </summary>
        static int LeerEntero(string mensaje)
        {
            Console.Write(mensaje);
            return int.Parse(Console.ReadLine());
        }
    }
}
