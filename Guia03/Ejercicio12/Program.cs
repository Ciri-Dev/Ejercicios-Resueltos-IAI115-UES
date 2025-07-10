using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 12- Diseñar una solución que realice la división aritmética. Se pide que 
             * se haga de la siguiente forma: se ingresarán 2 cadenas, la primera 
             * corresponde a las unidades del numerador y la segunda, son las unidades 
             * del denominador. Luego, se pedirán los valores numerador y denominador, 
             * respectivamente. El resultado podría ilustrarse de la siguiente manera: 
             * si ingresa “peras” y “niño”, y, luego ingresa 10 y 5, se mostrará como 
             * salida: 2 peras por niño. */

            // declaracion de variables
            string objetoNumerador, objetoDenominador;
            double numerador, denominador, division, resultado;

            // entrada de datos
            Console.Write("Ingrese las unidades del numerador: ");
            objetoNumerador = Console.ReadLine();
            Console.Write("Ingrese las unidades del denominador: ");
            objetoDenominador = Console.ReadLine();
            Console.Write("Ingrese la cantidad del numerador: ");
            numerador = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la cantidad del denominador: ");
            denominador = Convert.ToDouble(Console.ReadLine());

            // proceso de datos
            division = numerador / denominador;
            resultado = Math.Round(division);

            // salida de datos
            Console.WriteLine("El resultado total es: {0} {1} por {2}", resultado, objetoNumerador, objetoDenominador);
            Console.ReadKey();
        }
    }
}
