using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{   /*
     * 13- Diseñe una solución que dado un radio de un disco, la base y altura de 
     * un rectángulo, calcule e imprima el perímetro de la circunferencia del disco
     * y el perímetro del rectángulo así como el área del disco y el área del 
     * rectángulo.
     */
    internal class Program
    {   
        // declaracion de constantes
        const double PI = 3.1416;

        static void Main(string[] args)
        {
            // declaracion de variables
            double radio, baseRect, alturaRect;
            double perimetroCircunferencia, areaDisco, perimetroRectangulo, areaRectangulo;

            // entrada de datos
            radio = LeerDouble("Ingrese el radio del disco (valor positivo): ");
            baseRect = LeerDouble("Ingrese la base del rectángulo (valor positivo): ");
            alturaRect = LeerDouble("Ingrese la altura del rectángulo (valor positivo): ");

            // proceso de datos
            perimetroCircunferencia = CalcularPerimetroCircunferencia(radio);
            areaDisco = CalcularAreaDisco(radio);
            perimetroRectangulo = CalcularPerimetroRectangulo(baseRect, alturaRect);
            areaRectangulo = CalcularAreaRectangulo(baseRect, alturaRect);

            // salida de datos
            Console.WriteLine($"\nPerímetro del disco: {perimetroCircunferencia:0.00}");
            Console.WriteLine($"Área del disco: {areaDisco:0.00}");
            Console.WriteLine($"Perímetro del rectángulo: {perimetroRectangulo:0.00}");
            Console.WriteLine($"Área del rectángulo: {areaRectangulo:0.00}");

            Console.ReadKey();
        }

        /// <summary>
        /// Solicita al usuario un número y lo convierte a tipo double
        /// </summary>
        static double LeerDouble(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calcula el perímetro de una circunferencia
        /// </summary>
        static double CalcularPerimetroCircunferencia(double radio)
        {
            return 2 * PI * radio;
        }

        /// <summary>
        /// Calcula el área de un disco
        /// </summary>
        static double CalcularAreaDisco(double radio)
        {
            return PI * radio * radio;
        }

        /// <summary>
        /// Calcula el perímetro de un rectángulo
        /// </summary>
        static double CalcularPerimetroRectangulo(double baseRect, double alturaRect)
        {
            return 2 * (baseRect + alturaRect);
        }

        /// <summary>
        /// Calcula el área de un rectángulo
        /// </summary>
        static double CalcularAreaRectangulo(double baseRect, double alturaRect)
        {
            return baseRect * alturaRect;
        }       
    }
}
