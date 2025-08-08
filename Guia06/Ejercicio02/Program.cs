using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {   /*
         * 2- Dado un número entero, desplegar un mensaje indicando si es positivo, 
         * es negativo o es cero.
         */
        static void Main(string[] args)
        {
            //declaracion de variables
            int numero;

            // entrada de datos
            numero = LeerEntero("Ingrese un numero entero: ");

            //salida de datos
            EvaluarSigno(numero);
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para convertir a un numero tipo entero.
        /// </summary>
        static int LeerEntero(string mensaje)
        {
            Console.Write(mensaje);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Evalúa el signo de un número entero.
        /// </summary>
        static void EvaluarSigno(int numero)
        {
            if (numero > 0)
                Console.WriteLine("\nEl número es positivo");
            else if (numero < 0)
                Console.WriteLine("\nEl número es negativo");
            else
                Console.WriteLine("\nEl número es cero");
        }
    }
}
