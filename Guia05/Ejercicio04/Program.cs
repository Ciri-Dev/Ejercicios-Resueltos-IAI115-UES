using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{   /*
     * 4- Diseñe una solución que dados masa (libras), distancia (kilómetros) y tiempo
     * (minutos) en que recorre móvil horizontalmente desde un punto A a un punto B 
     * Calcule e imprima (usando sistema internacional) la energía cinética del móvil, 
     * además debe mostrar los datos originales de entrada (masa, distancia y tiempo).
     */
    internal class Program
    {
        // Constantes para conversión
        const double LIBRAS_A_KILOGRAMOS = 2.20462;
        const double KILOMETROS_A_METROS = 1000;
        const double MINUTOS_A_SEGUNDOS = 60;
        static void Main(string[] args)
        {   
            // declaracion de variables
            double masaLibras, distanciaKm, tiempoMin;
            double masaKg, distanciaM, tiempoS, velocidad, energiaCinetica;

            // entrada de datos
            masaLibras = LeerDouble("Ingrese la masa en libras:");
            distanciaKm = LeerDouble("Ingrese la distancia en kilómetros:");
            tiempoMin = LeerDouble("Ingrese el tiempo en minutos:");

            // proceso de datos
            masaKg = ConvertirMasa(masaLibras);
            distanciaM = ConvertirDistancia(distanciaKm);
            tiempoS = ConvertirTiempo(tiempoMin);
            velocidad = CalcularVelocidad(distanciaM, tiempoS);
            energiaCinetica = CalcularEnergiaCinetica(masaKg, velocidad);

            // salida de datos
            Console.WriteLine("\nDatos Originales:");
            Console.WriteLine($"Masa: {masaLibras:0.00} libras");
            Console.WriteLine($"Distancia: {distanciaKm:0.00} km");
            Console.WriteLine($"Tiempo: {tiempoMin:0.00} minutos");
            Console.WriteLine("\nEnergía Cinética Calculada:");
            Console.WriteLine($"Energía Cinética: {energiaCinetica:0.00} Joules");

            Console.ReadKey();
        }

        /// <summary>
        /// Muestra un mensaje en pantalla para solicitar un valor double.
        /// </summary>
        static double LeerDouble(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Convierte una masa dada en libras al sistema internacional (kilogramos).
        /// </summary>
        static double ConvertirMasa(double libras)
        {
            return libras / LIBRAS_A_KILOGRAMOS;
        }

        /// <summary>
        /// Convierte una distancia dada en kilómetros a metros.
        /// </summary>
        static double ConvertirDistancia(double km) 
        {
            return km * KILOMETROS_A_METROS;
        }

        /// <summary>
        /// Convierte tiempo dado en minutos a segundos.
        /// </summary>
        static double ConvertirTiempo(double minutos) 
        { 
            return minutos * MINUTOS_A_SEGUNDOS;
        }

        /// <summary>
        /// Calcula la velocidad a partir de distancia recorrida y tiempo.
        /// Se aplica la fórmula básica de velocidad: v = d / t.
        /// </summary>
        static double CalcularVelocidad(double distancia, double tiempo) 
        {
            return distancia / tiempo;
        }

        /// <summary>
        /// Calcula la energía cinética de un cuerpo en movimiento.
        /// Aplica la fórmula: K = 1/2 m v².
        /// </summary>                 
        static double CalcularEnergiaCinetica(double masaKg, double velocidad)
        {
            return 0.5 * masaKg * Math.Pow(velocidad, 2);
        }
         
    }
}  
