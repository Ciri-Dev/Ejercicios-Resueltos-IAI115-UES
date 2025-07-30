using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
             * 12- Diseñe una solución que dado un ángulo en grados calcule e imprima 
             * el seno, coseno y tangente para ese ángulo. Nota: todos los lenguajes 
             * de programación trabajan en radianes. 
             */

            // declaracion de variables
            double anguloGrados;
            double radianes, seno, coseno, tangente;

            // entrada de datos
            anguloGrados = LeerDouble("Ingrese el ángulo en grados: ");

            // proceso de datos
            radianes = ConvertirGradosARadianes(anguloGrados);
            seno = CalcularSeno(radianes);
            coseno = CalcularCoseno(radianes);
            tangente = CalcularTangente(radianes);

            // salida de datos
            Console.WriteLine($"\nSeno: {seno:F4}");
            Console.WriteLine($"Coseno: {coseno:F4}");
            Console.WriteLine($"Tangente: {tangente:F4}");

            Console.ReadKey();
        }

        /// <summary>
        /// Método que muestra un mensaje en consola, recibe una entrada del usuario y la convierte a tipo double.
        /// </summary>
        static double LeerDouble(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Convierte un ángulo de grados a radianes.
        /// </summary>
        static double ConvertirGradosARadianes(double grados)
        {
            return grados * Math.PI / 180;
        }

        /// <summary>
        /// Calcula el seno de un ángulo en radianes.
        /// </summary>
        static double CalcularSeno(double radianes)
        {
            return Math.Sin(radianes);
        }

        /// <summary>
        /// Calcula el coseno de un ángulo en radianes.
        /// </summary>
        static double CalcularCoseno(double radianes)
        {
            return Math.Cos(radianes);
        }

        /// <summary>
        /// Calcula la tangente de un ángulo en radianes.
        /// </summary>
        static double CalcularTangente(double radianes)
        {
            return Math.Tan(radianes);
        }

    }
}
