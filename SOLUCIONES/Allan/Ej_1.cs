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
            float ta = 0f, tr = 0f, tp = 0f;

            Console.WriteLine("Datos estadisticos de la asignatura");

            Console.Write("\nIngrese el total de alumnos: ");
            ta = Convert.ToSingle(Console.ReadLine());

            Console.Write("\nIngrese el total de alumnos reprobados: ");
            tr = Convert.ToSingle(Console.ReadLine());

            tp = ta - tr;

            tp = (tp / ta) * 100;

            tr = (tr / ta) * 100;

            Console.WriteLine($"\nLa cantidad de alumnos aprobado son: {tp:f0}%");
            Console.WriteLine($"La cantidad de alumnos reprobado son: {tr:f0}%");
        }
    }
}