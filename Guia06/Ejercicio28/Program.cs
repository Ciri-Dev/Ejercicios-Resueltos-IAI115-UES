using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{
    internal class Program
    {
        /*
         * 28- Diseñe una solución que dado un caracter ASCII, despliegue su codigo 
         * respectivo. Ejemplo: A es 65
         */
        static void Main(string[] args)
        {
            // declaracion de variables
            int codigo;
            char caracter;

            // entrada de datos
            caracter = LeerCaracterASCII("Ingrese un carácter ASCII: ");

            // proceso de datos
            codigo = ObtenerCodigoASCII(caracter);

            // salida de datos
            Console.WriteLine($"\nEl código ASCII del carácter '{caracter}' es: {codigo}");
            Console.ReadKey();
        }

        /// <summary>
        /// Convierte un caracter ASCII a su codigo correspondiente.
        /// </summary>
        static int ObtenerCodigoASCII(char caracter)
        {
            return Convert.ToInt32(caracter);
        }

        /// <summary>
        /// Lee un caracter que esté en el rango ASCII (0 - 127).
        /// </summary>
        static char LeerCaracterASCII(string mensaje)
        {
            char caracter;
            Console.Write(mensaje);
            caracter = Console.ReadKey().KeyChar;
            
            return caracter;
        }


    }
}
