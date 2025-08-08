using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        /*
         * 5- Diseñe una solución que dado un número real y un exponente entero; 
         * calcule el valor del número elevado a la potencia dada por el exponente. 
         * El cálculo debe poder realizarse para exponentes enteros entre -4 y 4, 
         * incluyendo el cero. NO DEBE USAR la clase Math.
         */
        static void Main()
        {   
            // declaracion de variables
            double baseNum, resultado;
            int exponente;

            // entrada de datos
            baseNum = LeerDouble("\nIngrese la base (número real): ");
            exponente = LeerEntero("\nIngrese el exponente (entero entre -4 y 4): ");

            // proceso y salida de datos
            if (exponente >= -4 && exponente <= 4)
            {
                resultado = CalcularPotencia(baseNum, exponente);
                Console.WriteLine($"\nResultado: {baseNum} ^ {exponente} = {resultado}");
            }
            else
            {
                Console.WriteLine("\nEl exponente debe estar en el rango de -4 a 4.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Lee un número de tipo double desde consola.
        /// </summary>
        static double LeerDouble(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
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
        /// Calcula manualmente la potencia del número base elevado al exponente.
        /// </summary>
        static double CalcularPotencia(double baseNum, int exponente)
        {
            if (exponente == 0)
                return 1;

            double resultado = 1;
            int veces = Math.Abs(exponente);

            for (int i = 0; i < veces; i++)
            {
                resultado *= baseNum;
            }

            return exponente < 0 ? 1 / resultado : resultado;
        }
    }
}
