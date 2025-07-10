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
        {
            /* 11- Diseñar una solución que realice y despliegue la suma aritmética 
             * de tres cantidades. Se pide que se haga de la siguiente forma: se debe
             * ingresar primero una cadena en la que el usuario escribe el nombre de 
             * los “objetos” a sumar (por ejemplo: manzanas), luego ingresa las tres 
             * cantidades, el programa las suma y reporta los resultados de la 
             * siguiente manera: 20 manzanas */

            // DECLARACION DE VARIABLES
            string objetos;
            double cantidad1, cantidad2, cantidad3, suma;

            // ENTRADA DE DATOS
            Console.Write("Ingrese el nombre de los objetos que desea sumar: ");
            objetos = Console.ReadLine();
            Console.Write("Ingrese la primera cantidad que desea sumar: ");
            cantidad1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda cantidad que desea sumar: ");
            cantidad2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la tercera cantidad que desea sumar: ");
            cantidad3 = double.Parse(Console.ReadLine());

            // PROCESO DE DATOS
            suma = cantidad1 + cantidad2 + cantidad3;

            // SALIDA DE DATOS
            Console.WriteLine("\nEl resultado total de los objetos es: {0} {1}", suma, objetos);
            Console.ReadKey();
        }
    }
}
