using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* 4- Un docente necesita calcular la nota final de la asignatura de 
             * Introducción a la Informática que viene dada por el promedio de 
             * 4 notas.  Realice un programa que permita realizarlo. */

            // declaracion de variables
            double nota1, nota2, nota3, nota4, promedio;

            // entrada de datos
            Console.Write("Ingrese la primera nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la tercera nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cuarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            // proceso de datos
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            // salida de datos
            Console.WriteLine($"\nLa nota final es: {promedio:F2}");
            Console.ReadKey();
        }
    }
}
