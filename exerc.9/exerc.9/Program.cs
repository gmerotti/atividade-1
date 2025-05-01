using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o diametro do circulo:");
            double diametro = double.Parse(Console.ReadLine());

            double raio = diametro / 2;
            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine($"a area do seu circulo é:{area:F2}");
        }
    }
}
