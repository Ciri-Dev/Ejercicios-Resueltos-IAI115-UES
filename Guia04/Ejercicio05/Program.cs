using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5- Calcular el monto a pagar en dólares ($) a un empleado, por las 
             * vacaciones anuales, sabiendo que la ley dice que gozará vacaciones 
             * y que tiene derecho a 15 días de salario más un 30% del mencionado 
             * salario. */

            // declaracion de variables
            const double BONO = 0.30;
            double salario, medioSalario, bono, montoTotal;

            // entrada de datos
            Console.Write("Ingrese su salario mensual: $");
            salario = double.Parse(Console.ReadLine());

            // proceso de datos
            medioSalario = salario / 2;  // salario de 15 dias
            bono = salario * BONO;       // bono del 30% sobre el sueldo
            montoTotal = medioSalario + bono;

            // salida de datos
            Console.WriteLine($"\nEl monto final a pagar es: ${montoTotal:F2}");
            Console.ReadKey();
        }
    }
}
