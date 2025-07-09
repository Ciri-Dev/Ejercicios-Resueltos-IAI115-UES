using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp_aritmeticas
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* 1- Encuentre el valor de las expresiones siguientes e indique 
             de que tipo debe ser la variable que almacena la respuesta segun
            el resultado obtenido*/

            // declaracion de variables
            var a = 2 * 3 + 5.0 / 3;
            var b = 72.0 / 8 + 3 - 4 * 2.0 / 4 + 6;
            var c = (4.5 + 5) / (2 + 6) * 4.0;
            var d = 9 - 5 - 3;
            var e = 2.0 / 3 + 3.0 / 5;
            var f = 9.0 / 2 / 5;
            var g = ((12 + 3) / 2.0) / (8 - (5 + 1));
            var h = 12.0 / 2 * 3;
            var i = 12.0 / 3 * (6 + (30 - 15 * 3 + (-3.0) / 2) * 1);
            var j = 4.0 / 2 * 3 / 6 + 6.0 / 2 / 1 / Math.Pow(5, 2) / 4 * 2;
            var k = 6 * 8 * (180 % 6) % 5 * 11 - 15;
            var l = Math.Pow((7 * 10 - 5 % 3 * 4 + 9), 2);
            var m = (7 * (10 - 5) / 3.0) * Math.Pow((4 + 9), 2);
            var n = (7 * 10 - 5) / Math.Pow((3 * 4 + 9), 2);
            var o = Math.Sqrt(Math.Pow(4, 2));
            var p = Math.Pow(Math.Sqrt(4), 2);
            var q = 3 * Math.Tan(Math.PI / 6) - 2 * Math.Sin(Math.PI / 6) / Math.Cos(Math.PI / 6);

            //salida del tipo de dato de cada expresion
            Console.WriteLine("a: " + a.GetType());
            Console.WriteLine("b: " + b.GetType());
            Console.WriteLine("c: " + c.GetType());
            Console.WriteLine("d: " + d.GetType());
            Console.WriteLine("e: " + e.GetType());
            Console.WriteLine("f: " + f.GetType());
            Console.WriteLine("g: " + g.GetType());
            Console.WriteLine("h: " + h.GetType());
            Console.WriteLine("i: " + i.GetType());
            Console.WriteLine("j: " + j.GetType());
            Console.WriteLine("k: " + k.GetType());
            Console.WriteLine("l: " + l.GetType());
            Console.WriteLine("m: " + m.GetType());
            Console.WriteLine("n: " + n.GetType());
            Console.WriteLine("o: " + o.GetType());
            Console.WriteLine("p: " + p.GetType());
            Console.WriteLine("q: " + q.GetType());

            Console.ReadKey();
        }
    }
}
