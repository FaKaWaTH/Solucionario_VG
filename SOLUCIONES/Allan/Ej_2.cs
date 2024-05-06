using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listado6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.-

            float f, c, a, m;

            Console.WriteLine("\n\tConversión de Fahrenhait a Celsius");

            Console.Write("\n  Ingrese la temperatura en Fahrenhait: ");
            f = Convert.ToSingle(Console.ReadLine());

            Console.Write("\n  Ingrese la cantidad de agua precipitada: ");
            a = Convert.ToSingle(Console.ReadLine());

            c = ((f - 32) * 5) / 9;
            m = a * 25.4f;

            Console.WriteLine($"\n  {f} Fahrenhait son {c:f1}° Celsius\n  {a} Pulgadas son {m:f1} milimetros ");
        }
    }
}