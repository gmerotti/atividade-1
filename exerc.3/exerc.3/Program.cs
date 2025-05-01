using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite a diagonal do quadrado: ");
            double diagonal = double.Parse(Console.ReadLine());


            double area = (diagonal * diagonal) / 2;


            Console.WriteLine("a área do quadrado é:" + area);
        }
    }
}
