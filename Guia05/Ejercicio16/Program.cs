using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{   /*
     * 16- Una empresa debe manejar los costos, ganancias e impuestos del negocio. 
     * Diseñe una solución que dados en dólares para un año fiscal, las ventas totales,
     * impuesto iva (13%) de las ventas, los costos totales, calcule e imprima la 
     * ganancia bruta y la ganancia neta (después de aplicar 20% de impuesto sobre la renta).  
     */
    internal class Program
    {   
        // declaracion de constantes
        const double IVA_PORCENTAJE = 0.13;
        const double ISR_PORCENTAJE = 0.20;

        static void Main(string[] args)
        {
            // declaracion de variables
            double ventas, costos;
            double iva, gananciaBruta, impuestoRenta, gananciaNeta;

            // entrada de datos
            ventas = LeerDouble("Ingrese las ventas totales en dólares: ");
            costos = LeerDouble("Ingrese los costos totales en dólares: ");

            // proceso de datos
            iva = CalcularIVA(ventas);
            gananciaBruta = CalcularGananciaBruta(ventas, costos, iva);
            impuestoRenta = CalcularISR(gananciaBruta);
            gananciaNeta = CalcularGananciaNeta(gananciaBruta, impuestoRenta);

            // salida de datos
            Console.WriteLine($"\nResultados del año fiscal:");
            Console.WriteLine($"IVA aplicado (13%): ${iva:F2}");
            Console.WriteLine($"Ganancia Bruta: ${gananciaBruta:F2}");
            Console.WriteLine($"Impuesto sobre la Renta (20%): ${impuestoRenta:F2}");
            Console.WriteLine($"Ganancia Neta: ${gananciaNeta:F2}");

            Console.ReadKey();
        }

        /// <summary>
        /// Solicita al usuario un número y lo convierte a double.
        /// </summary>
        static double LeerDouble(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Calcula el IVA del 13% sobre el total de ventas.
        /// </summary>
        static double CalcularIVA(double ventas)
        {
            return ventas * IVA_PORCENTAJE;
        }

        /// <summary>
        /// Calcula la ganancia bruta restando costos e IVA a las ventas.
        /// </summary>
        static double CalcularGananciaBruta(double ventas, double costos, double iva)
        {
            return ventas - costos - iva;
        }

        /// <summary>
        /// Calcula el Impuesto Sobre la Renta (ISR) del 20% sobre la ganancia bruta.
        /// </summary>
        static double CalcularISR(double gananciaBruta)
        {
            return gananciaBruta * ISR_PORCENTAJE;
        }

        /// <summary>
        /// Calcula la ganancia neta después de aplicar el ISR.
        /// </summary>
        static double CalcularGananciaNeta(double gananciaBruta, double isr)
        {
            return gananciaBruta - isr;
        }
    }
}
