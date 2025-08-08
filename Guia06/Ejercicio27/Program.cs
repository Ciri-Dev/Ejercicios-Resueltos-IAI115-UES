using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    internal class Program
    {
        /*
         * 27- Diseñe una solución que dado un código ASCII, despliegue su caracter 
         * respectivo. Ejemplo: 65 es A
         */
        static void Main(string[] args)
        {   
            // declaracion de variables
            int codigo;
            char caracter;

            // entrada de datos
            codigo = LeerCodigoASCII("Ingrese un código ASCII (0–255): ");

            // proceso de datos
            caracter = ObtenerCaracterASCII(codigo);

            // salida de datos
            Console.WriteLine($"\nEl carácter correspondiente al código {codigo} es: '{caracter}'");
            Console.ReadKey();
        }

        /// <summary>
        /// Convierte un código ASCII a su carácter correspondiente.
        /// </summary>
        static char ObtenerCaracterASCII(int codigo)
        {
            return Convert.ToChar(codigo);
        }

        /// <summary>
        /// Lee un número entero y valida que esté en el rango ASCII.
        /// </summary>
        static int LeerCodigoASCII(string mensaje)
        {
            int codigo;
            Console.Write(mensaje);
            codigo = int.Parse(Console.ReadLine());

            if (codigo < 0 || codigo > 255)
            {
                Console.WriteLine("El código debe estar entre 0 y 255.");
            }

            return codigo;
        }
    }
}
