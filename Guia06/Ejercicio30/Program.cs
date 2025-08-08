using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    internal class Program
    {
        /*
         * 30- Diseñe una solución que dado el monto de compra y el color de la 
         * bolita extraída de una tómbola, calcule y despliegue el total a pagar. 
         * Considerar que si el color es blanco no tiene descuento, el azul tiene 
         * 5% y el verde tiene 10%.
         */


        static void Main(string[] args)
        {   
            // declaracion de variables
            double monto, total;
            string color;

            // entrada de datos
            Console.Write("Ingrese el monto de la compra: $");
            monto = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el color de la bolita (blanco, azul, verde): ");
            color = Console.ReadLine();

            // proceso de datos
            total = CalcularTotal(monto, color);

            // salida de datos
            Console.WriteLine($"\nTotal a pagar: ${total:0.00}");
            Console.ReadKey();
        }

        /// <summary>
        /// Calcula el total a pagar según el color de la bolita extraída.
        /// </summary>
        static double CalcularTotal(double monto, string color)
        {
            double descuento = 0;

            if (color.ToLower() == "azul")
                descuento = 0.05;
            else if (color.ToLower() == "verde")
                descuento = 0.10;
            

            return monto - (monto * descuento);
        }

    }
}
