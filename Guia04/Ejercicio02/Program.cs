using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* 2- Elabore un programa que permita encontrar el área de un triángulo 
             * rectángulo, y calcule el área de un rectángulo, mostrando los 
             * resultados con textos de las unidades de medida correspondiente */

            // declaracion de variables
            double baseTriangulo, alturaTriangulo, baseRectangulo, alturaRectangulo;
            double areaTriangulo, areaRectangulo;

            // entrada de datos
            Console.WriteLine("Ingrese base del triángulo rectángulo (en cm): ");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese altura del triángulo rectángulo (en cm): ");
            alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese base del rectángulo (en cm): ");
            baseRectangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese altura del rectángulo (en cm): ");
            alturaRectangulo = Convert.ToDouble(Console.ReadLine());

            // proceso de datos
            areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
            areaRectangulo = baseRectangulo * alturaRectangulo;

            // salida de datos
            Console.WriteLine($"Área del triángulo rectángulo: {areaTriangulo} cm²");
            Console.WriteLine($"Área del rectángulo: {areaRectangulo} cm²");
            Console.ReadKey();
        }
    }
}
