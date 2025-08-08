using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {   /*
         * 4- Diseñe una solución que dado un número calcule el valor absoluto del 
         * número. El número puede ser entero o real. NO DEBE USAR la clase Math.
         */
        static void Main()
        {   
            // declaracion de variable
            int numero;

            // entrada de datos
            numero = LeerEntero("\nIngrese un número entero para calcular su valor absoluto: ");

            // proceso y salida de datos
            CalcularValorAbsoluto(numero);
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
        /// Calcula y muestra el valor absoluto de un número entero.
        /// </summary>
        static void CalcularValorAbsoluto(int numero)
        {
            if (numero < 0)
            {
                Console.WriteLine($"\nValor Absoluto: {-numero}");
            }
            else
            {
                Console.WriteLine($"\nValor Absoluto: {numero}");
            }
        }
    }
}
