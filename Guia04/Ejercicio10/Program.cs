using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10- Diseñe una solución que dado un ángulo en grados calcule e imprima
             * el seno, coseno y tangente para ese ángulo. Nota: todos los lenguajes 
             * de programación trabajan en radianes */

            // declaracion de variables
            double anguloGrados, anguloRadianes, seno, coseno, tangente;

            // entrada de datos
            Console.Write("Ingrese el angulo en grados: ");
            anguloGrados = double.Parse(Console.ReadLine());

            // proceso de datos
            anguloRadianes = anguloGrados * Math.PI / 180;  // convertir grados a radianes
            seno = Math.Sin(anguloRadianes);
            coseno = Math.Cos(anguloRadianes);
            tangente = Math.Tan(anguloRadianes);

            // salida de datos
            Console.WriteLine($"\nSeno de {anguloGrados} grados: {seno}");
            Console.WriteLine($"Coseno de {anguloGrados} grados: {coseno}");
            Console.WriteLine($"Tangente de {anguloGrados} grados: {tangente}");
            Console.ReadKey();
        }
    }
}
