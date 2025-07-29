using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{   /*
     Dada la masa de un cuerpo y dado el tiempo que tarda en caer al suelo de una altura
    h sobre la superficie de la tierra. Partiendo de que dicho cuerpo está en reposo a esa 
    altura h y luego se deja caer (se suelta, por lo que Vi=0). Se pide que calcule: 
    a) La altura (distancia que recorre el cuerpo verticalmente) hasta el suelo. h= Vi t + ½ . 
    g . t2 donde Vi es velocidad inicial, t tiempo y g gravedad y h altura. 
    b) La energía potencial gravitacional del cuerpo cuando está a la altura h. 
    Epg = w . h donde w es peso y h la altura. 
    13 
    c) La energía cinética del cuerpo, justo al momento de llegar al piso: 
    K = 1/2 m.v 2 
    **Todo en unidades sistema internacional y Suponga que son 
    “movimientos verticales en el vacío” sin resistencia. El peso del cuerpo 
    W = m.g donde w es peso, m es masa y g es gravedad de la tierra. 
    La velocidad del cuerpo, al llegar al suelo Vf  = g . t donde Vf es la 
    velocidad, al llegar al suelo, g es la gravedad y t es el tiempo en 
    segundos que tarda en caer, el objeto. g = 9.8 mts/seg2
     */
    internal class Program
    {
        const double GRAVEDAD = 9.8;
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Movimiento Vertical en el Vacío\n");

            // entrada de datos
            double masa = LeerDouble("Ingrese la masa del cuerpo (kg):");
            double tiempo = LeerDouble("Ingrese el tiempo de caída (segundos):");

            // proceso de datos
            double altura = CalcularAltura(tiempo);
            double peso = CalcularPeso(masa);
            double energiaPotencial = CalcularEnergiaPotencial(peso, altura);
            double velocidadFinal = CalcularVelocidadFinal(tiempo);
            double energiaCinetica = CalcularEnergiaCinetica(masa, velocidadFinal);

            // salida de datos
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Altura recorrida: {altura:F2} metros");
            Console.WriteLine($"Energía Potencial Gravitacional: {energiaPotencial:F2} Joules");
            Console.WriteLine($"Velocidad al llegar al suelo: {velocidadFinal:F2} m/s");
            Console.WriteLine($"Energía Cinética al llegar al suelo: {energiaCinetica:F2} Joules");

            Console.ReadKey();
        }

        static double LeerDouble(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
        }

        static double CalcularAltura(double tiempo)
        {
            return 0.5 * GRAVEDAD * Math.Pow(tiempo, 2); 
        }

        static double CalcularPeso(double masa)
        {
            return masa * GRAVEDAD;
        }

        static double CalcularEnergiaPotencial(double peso, double altura)
        {
            return peso * altura;
        }

        static double CalcularVelocidadFinal(double tiempo)
        {
            return GRAVEDAD * tiempo;
        }

        static double CalcularEnergiaCinetica(double masa, double velocidad)
        {
            return 0.5 * masa * Math.Pow(velocidad, 2);
        }
    }
}
