using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());

            double mediaGeometrica = Math.Sqrt(a * b);

            Console.WriteLine("a média geométrica é: " + mediaGeometrica);
        }
    }
}
