using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {   /*
         5- Se necesita calcular la superficie y el volumen de prismas 
        de tipo rectangular y triangular (ver figura). En el prisma 
        triangular considere que todos los lados del triángulo son 
        iguales, mientras que para el rectangular todos los lados 
        son diferentes. Diseñe una solución que calcule e imprima 
        superficie y volumen en unidades cuadradas y unidades 
        cúbicas respectivamente.
         */
        static void Main(string[] args)
        {
            // Prisma rectangular
            double largo = LeerDouble("Ingrese el largo del prisma rectangular:");
            double ancho = LeerDouble("Ingrese el ancho del prisma rectangular:");
            double alturaR = LeerDouble("Ingrese la altura del prisma rectangular:");

            double volumenRect = CalcularVolumenRectangular(largo, ancho, alturaR);
            double superficieRect = CalcularSuperficieRectangular(largo, ancho, alturaR);

            Console.WriteLine("\nPrisma Rectangular:");
            Console.WriteLine($"Volumen: {volumenRect:0.00} unidades cúbicas");
            Console.WriteLine($"Superficie: {superficieRect:0.00} unidades cuadradas");

            // Prisma triangular equilátero
            double lado = LeerDouble("\nIngrese el lado del triángulo base del prisma triangular:");
            double alturaT = LeerDouble("Ingrese la altura del prisma triangular:");

            double volumenTri = CalcularVolumenTriangular(lado, alturaT);
            double superficieTri = CalcularSuperficieTriangular(lado, alturaT);

            Console.WriteLine("\nPrisma Triangular Equilátero:");
            Console.WriteLine($"Volumen: {volumenTri:0.00} unidades cúbicas");
            Console.WriteLine($"Superficie: {superficieTri:0.00} unidades cuadradas");

            Console.ReadKey();
        }

        static double LeerDouble(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        static double CalcularVolumenRectangular(double largo, double ancho, double altura)
        {
            return largo * ancho * altura;
        }

        static double CalcularSuperficieRectangular(double largo, double ancho, double altura)
        {
            return 2 * (largo * ancho + largo * altura + ancho * altura);
        }

        static double CalcularVolumenTriangular(double lado, double altura)
        {
            double areaBase = (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);
            return areaBase * altura;
        }

        static double CalcularSuperficieTriangular(double lado, double altura)
        {
            double areaBase = (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);
            double areaLateral = 3 * lado * altura;
            return 2 * areaBase + areaLateral;
        }

    }
}
