using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {   /*
         * 3- En la empresa “Plásticos S.A.”, se ha descompuesto el medidor de 
         * temperatura en grados centígrados con graduación de color. Pero se tiene un 
         * termómetro en grados fahrenheit sin graduación de color. Crear una solución 
         * que dada la temperatura en grados fahrenheit muestre el color y mensaje que 
         * corresponde al medidor de grados centígrados.
         */
        
        static void Main()
        {   
            // declaracion de variables
            double temperatura, celsius;

            // entrada de datos
            Console.Write("\nIngrese la temperatura en grados Fahrenheit: ");
            temperatura = double.Parse(Console.ReadLine());

            // proceso de datos
            celsius = ConvertirACelsius(temperatura);

            // salida de datos
            Console.WriteLine($"\nTemperatura (Celsius): {celsius:F2}");
            CalcularTemperatura(celsius);
            Console.ReadKey();
        }

        /// <summary>
        /// Convierte una temperatura de Fahrenheit a Celsius.
        /// </summary>
        static double ConvertirACelsius(double temp)
        {
            return 5.0 / 9.0 * (temp - 32);
        }

        /// <summary>
        /// Calcula y muestra un mensaje según la temperatura en Celsius.
        /// </summary>
        static void CalcularTemperatura(double temp)
        {
            if (temp <= 15)
            {
                Console.WriteLine("Azul (Frío)");
            }
            else if (temp > 15 && temp <= 35)
            {
                Console.WriteLine("Verde (Normal)");
            }
            else if (temp > 35 && temp <= 45)
            {
                Console.WriteLine("Amarillo (Precaución)");
            }
            else if (temp > 45)
            {
                Console.WriteLine("Rojo (Peligro)");
            }
        }
    }
}
