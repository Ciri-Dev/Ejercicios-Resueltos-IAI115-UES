using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        /*
         * 9- Utilizando variables individuales de tipos primitivos, diseñe una solución
         * que dada una fracción mixta,(Un número entero y una fracción propia juntos) 
         * de la forma 4 ⅓ (cuatro unidades un tercio) la convierta a una fracción no 
         * mixta, expresada totalmente como una fracción a/b Sin parte entera. Debe 
         * imprimir la fracción mixta y la no mixta a pantalla.
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            int numeroEntero, numerador, denominador;
            int nuevoNumerador;

            // entrada de datos
            numeroEntero = LeerEntero("Ingrese el numero entero de la fracción mixta: ");
            numerador = LeerEntero("Ingrese el numerador de la fracción propia: ");
            denominador = LeerEntero("Ingrese el denominador de la fracción propia: ");

            // proceso de datos
            nuevoNumerador = ConvertirMixtaANoMixta(numeroEntero, numerador, denominador);

            // salida de datos
            ImprimirFracciones(numeroEntero, numerador, denominador, nuevoNumerador);
            Console.ReadKey();
        }

        /// <summary>
        /// Solicita un número entero al usuario 
        /// </summary>
        static int LeerEntero(string mensaje)
        {
            Console.Write(mensaje);
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Convierte una fracción mixta a una fracción impropia (a/d)
        /// </summary>
        static int ConvertirMixtaANoMixta(int entero, int numerador, int denominador)
        {
            return (entero * denominador) + numerador;
        }

        /// <summary>
        /// Imprime la fracción mixta y su equivalente como fracción impropia
        /// </summary>
        static void ImprimirFracciones(int entero, int numerador, int denominador, int resultado)
        {
            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine($"Fracción mixta: {entero} {numerador}/{denominador}");
            Console.WriteLine($"Fracción no mixta: {resultado}/{denominador}");
        }
        
    }
}
