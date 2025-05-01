using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aresta;
            int área;
            Console.Write("digite a aresta:");
            aresta = int.Parse(Console.ReadLine());

            área = aresta * aresta;

            Console.WriteLine("a área é:"+ área);

        }
    }
}
