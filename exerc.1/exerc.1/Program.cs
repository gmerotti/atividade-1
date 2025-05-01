using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bas3;
            int altura;
            int área;

            Console.Write("digite a base:");
            bas3 = int.Parse(Console.ReadLine());

            Console.Write("digite a altura:");

            altura = int.Parse(Console.ReadLine());

            área=bas3 * altura;
            Console.WriteLine("o valor da altura é:" + área);
        }
    }
}
