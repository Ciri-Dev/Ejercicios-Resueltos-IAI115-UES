using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    internal class Program
    {
        /*
         * 31- Diseñe una solución que dado el número correlativo de departamento de 
         * El Salvador (número correlativo según la posición en orden alfabéticamente 
         * y ascendente), despliegue el nombre del Departamento y nombre de Cabecera 
         * Departamental del mismo. 
         */


        // variables globales
        static string departamento;
        static string cabecera;

        static void Main(string[] args)
        {   
            // declaracion de variables
            int numero;

            // entrada de datos
            Console.Write("Ingrese el número correlativo del departamento (1–14): ");
            numero = int.Parse(Console.ReadLine());

            // proceso y salida de datos
            if (numero >= 1 && numero <= 14)
            {
                ObtenerDepartamento(numero);
                Console.WriteLine("\nDepartamento: " + departamento);
                Console.WriteLine("Cabecera Departamental: " + cabecera);
            }
            else
            {
                Console.WriteLine("\nNúmero fuera del rango válido.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Determina el nombre del departamento y su cabecera departamental en 
        /// El Salvador según el número correlativo (1–14), ordenado alfabéticamente.
        /// </summary>
        static void ObtenerDepartamento(int numero)
        {
            if (numero == 1)
            {
                departamento = "Ahuachapán";
                cabecera = "Ahuachapán";
            }
            else if (numero == 2)
            {
                departamento = "Cabañas";
                cabecera = "Sensuntepeque";
            }
            else if (numero == 3)
            {
                departamento = "Chalatenango";
                cabecera = "Chalatenango";
            }
            else if (numero == 4)
            {
                departamento = "Cuscatlán";
                cabecera = "Cojutepeque";
            }
            else if (numero == 5)
            {
                departamento = "La Libertad";
                cabecera = "Santa Tecla";
            }
            else if (numero == 6)
            {
                departamento = "La Paz";
                cabecera = "Zacatecoluca";
            }
            else if (numero == 7)
            {
                departamento = "La Unión";
                cabecera = "La Unión";
            }
            else if (numero == 8)
            {
                departamento = "Morazán";
                cabecera = "San Francisco Gotera";
            }
            else if (numero == 9)
            {
                departamento = "San Miguel";
                cabecera = "San Miguel";
            }
            else if (numero == 10)
            {
                departamento = "San Salvador";
                cabecera = "San Salvador";
            }
            else if (numero == 11)
            {
                departamento = "San Vicente";
                cabecera = "San Vicente";
            }
            else if (numero == 12)
            {
                departamento = "Santa Ana";
                cabecera = "Santa Ana";
            }
            else if (numero == 13)
            {
                departamento = "Sonsonate";
                cabecera = "Sonsonate";
            }
            else if (numero == 14)
            {
                departamento = "Usulután";
                cabecera = "Usulután";
            }
            else
            {
                departamento = "Desconocido";
                cabecera = "Desconocido";
            }
        }
    }
}
