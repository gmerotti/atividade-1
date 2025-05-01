using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite seu valor em graus Celsius:");
            double C = double.Parse(Console.ReadLine());

            double F = (9 / 5) * C + 32;

            Console.WriteLine($"{C} °C equivalem a {F:F1} °F.");

        }
    }
}
