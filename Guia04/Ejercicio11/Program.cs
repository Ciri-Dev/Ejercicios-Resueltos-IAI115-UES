using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* 11- La Distribuidora de Gas la Esquinita, compra y vende cilindros de 
             * gas de 3 medidas que son 5 libras, 25 libras y 35 libras de gas 
             * licuado. Diseñe una solución que calcule e imprima para cada medida el
             * precio del cilindro (incluido IVA), esto cuando se recibe un pedido. 
             * Por lo que dadas las cantidades de cada medida de cilindro, el costo de
             * compra, el porcentaje de ganancia del negocio fijo de (30%) y el 
             * impuesto que se debe cobrar IVA (13%) al cliente e impuesto de renta 
             * que debe pagar el Empresario (10%) sobre la ganancia. Se pide que 
             * imprima para cada medida el precio por unidad y que imprima el impuesto
             * renta que deberá pagar el Empresario por esta entrega una vez vendida.
             * También debe imprimir el impuesto IVA que pagará el público en total, 
             * por la compra de esta entrega. Omita otros costos como son local, 
             * energía, etc. SOLO considere el costo de compra. */

            //const double cilindro10Libras = 4.61;
            //const double cilindro25libras = 11.13;
            //const double cilindro35libras = 15.50;

            //// Cálculos directos de ganancia (30%) e impuesto de renta (10%)
            //double resultado1 = gas_10libras * 0.30;
            //double lb10_resultado2 = resultado1 * 0.10;

            //double resultado3 = gas_25libras * 0.30;
            //double lb25_resultado4 = resultado3 * 0.10;

            //double resultado5 = gas_35libras * 0.30;
            //double lb35_resultado6 = resultado5 * 0.10;

            //// Mostrar los resultados
            //Console.WriteLine("\n*************************************");
            //Console.WriteLine("* DISTRIBUIDORA DE GAS LA ESQUINITA *");
            //Console.WriteLine("*************************************\n");

            //Console.WriteLine("Medida:\t10 Lb\t25 Lb\t35 Lb");
            //Console.WriteLine($"Precios\t${gas_10libras:F2}\t${gas_25libras:F2}\t${gas_35libras:F2}");
            //Console.WriteLine($"Impuesto\t${lb10_resultado2:F2}\t${lb25_resultado4:F2}\t${lb35_resultado6:F2}");
            //Console.ReadKey();



            int cant5Lb = 4;
            int cant25Lb = 3;
            int cant35Lb = 2;

            double costo5Lb = 3.25;
            double costo25Lb = 10.75;
            double costo35Lb = 14.60;

            // Constantes
            double gananciaPorc = 0.30;
            double ivaPorc = 0.13;
            double rentaPorc = 0.10;

            // Cálculos para cada medida

            // --- 5 Libras ---
            double precioUnidad5Lb = costo5Lb + (costo5Lb * gananciaPorc);
            double ivaUnidad5Lb = precioUnidad5Lb * ivaPorc;
            double precioFinal5Lb = precioUnidad5Lb + ivaUnidad5Lb;
            double rentaUnidad5Lb = (costo5Lb * gananciaPorc) * rentaPorc;

            double totalIva5Lb = ivaUnidad5Lb * cant5Lb;
            double totalRenta5Lb = rentaUnidad5Lb * cant5Lb;

            // --- 25 Libras ---
            double precioUnidad25Lb = costo25Lb + (costo25Lb * gananciaPorc);
            double ivaUnidad25Lb = precioUnidad25Lb * ivaPorc;
            double precioFinal25Lb = precioUnidad25Lb + ivaUnidad25Lb;
            double rentaUnidad25Lb = (costo25Lb * gananciaPorc) * rentaPorc;

            double totalIva25Lb = ivaUnidad25Lb * cant25Lb;
            double totalRenta25Lb = rentaUnidad25Lb * cant25Lb;

            // --- 35 Libras ---
            double precioUnidad35Lb = costo35Lb + (costo35Lb * gananciaPorc);
            double ivaUnidad35Lb = precioUnidad35Lb * ivaPorc;
            double precioFinal35Lb = precioUnidad35Lb + ivaUnidad35Lb;
            double rentaUnidad35Lb = (costo35Lb * gananciaPorc) * rentaPorc;

            double totalIva35Lb = ivaUnidad35Lb * cant35Lb;
            double totalRenta35Lb = rentaUnidad35Lb * cant35Lb;

            // Totales generales
            double totalIva = totalIva5Lb + totalIva25Lb + totalIva35Lb;
            double totalRenta = totalRenta5Lb + totalRenta25Lb + totalRenta35Lb;

            // Presentación de resultados
            Console.WriteLine("\n*************************************");
            Console.WriteLine("* DISTRIBUIDORA DE GAS LA ESQUINITA *");
            Console.WriteLine("*************************************\n");

            Console.WriteLine("MEDIDA\tPRECIO C/U (con IVA)\tIMP. RENTA TOTAL");
            Console.WriteLine($"5 LB\t${precioFinal5Lb:F2}\t\t\t${totalRenta5Lb:F2}");
            Console.WriteLine($"25 LB\t${precioFinal25Lb:F2}\t\t\t${totalRenta25Lb:F2}");
            Console.WriteLine($"35 LB\t${precioFinal35Lb:F2}\t\t\t${totalRenta35Lb:F2}");

            Console.WriteLine($"\nImpuesto IVA que pagará el público por toda la entrega: ${totalIva:F2}");
            Console.WriteLine($"Impuesto Renta total que pagará el empresario: ${totalRenta:F2}\n");
            Console.ReadKey();
        }
    }
}
