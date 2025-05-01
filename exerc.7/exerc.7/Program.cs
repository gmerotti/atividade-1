using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite a quantidade de milhas marítimas: ");
            double milhas = double.Parse(Console.ReadLine());

            double metros = milhas * 1852;
            double quilometros = metros / 1000;

            Console.WriteLine($"{milhas} milhas marítimas equivalem a {quilometros:F2} km.");
        }
    }
}
