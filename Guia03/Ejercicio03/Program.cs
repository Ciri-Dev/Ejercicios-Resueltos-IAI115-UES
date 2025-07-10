using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* 3- La energía potencial gravitacional es la energía que posee un cuerpo, 
             * debido a su posición en un campo gravitacional. Calcular la energía 
             * potencial gravitacional terrestre para un cuerpo DADAS la masa m y una
             * determinada altura h de la tierra. La fórmula es Epg = w.h, donde el 
             * peso w = m.g;  es decir, masa m por gravedad g.*/

            // declaracion de variables
            const float GRAVEDAD = 9.8f;

            double masa, altura, peso;
            double ePotencialGravitacional;

            Console.WriteLine("Ingrese el valor de la masa: ");
            masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura: ");
            altura = double.Parse(Console.ReadLine());

            // proceso de datos
            peso = masa * GRAVEDAD;
            ePotencialGravitacional = peso * altura;

            // salida de datos
            Console.WriteLine("La energia potencial gravitacional es: {0:####.##}", ePotencialGravitacional);
            Console.ReadKey();
        }
    }
}
