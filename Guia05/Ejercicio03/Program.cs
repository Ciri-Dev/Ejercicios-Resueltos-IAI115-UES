using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        /* 3-
         * Diseñe una solución que dada una temperatura en grados centígrados la convierta 
         * a grados fahrenheit y grados kelvin.Debe mostrar la temperatura original y las 
         * dos conversiones en pantalla, con sus respectivos mensajes de entrada y salida.
        */
        static void Main(string[] args)
        {   
            // declaracion de variables
            double celsius, fahrenheit, kelvin;

            // entrada de datos
            celsius = LeerDouble("Ingrese la temperatura en grados Celsius: ");

            // proceso de datos
            fahrenheit = ConvertirAFahrenheit(celsius);
            kelvin = ConvertirAKelvin(celsius);

            // salida de datos
            Console.WriteLine($"\nLa temperatura en grados Fahrenheit es: {fahrenheit:0.0} grados");
            Console.WriteLine($"La temperatura en grados Kelvin es: {kelvin:F1} grados");
            Console.ReadKey();
        }

        /// <summary>
        /// Método que solicita al usuario una entrada numérica (double)
        /// Mostrando un mensaje personalizado, lee y devuelve el valor ingresado.
        /// </summary>
        static double LeerDouble(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Método que convierte una temperatura en grados Celsius a Fahrenheit
        /// </summary>
        static double ConvertirAFahrenheit(double temp)
        {
            return temp * 1.8 + 32;
        }

        /// <summary>
        /// Método que convierte una temperatura en grados Celsius a Kelvin
        /// </summary>
        static double ConvertirAKelvin(double temp)
        {
            return temp + 273.15;
        }
    }
}
