using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o valor do primeiro item:");
            double item1 = double.Parse(Console.ReadLine());

            Console.Write("digite o valor do segundo item:");
            double item2 = double.Parse(Console.ReadLine());

            Console.Write("digite o valor do terceiro item:");
            double item3 = double.Parse(Console.ReadLine());

            Console.Write("digite o valor do quarto item:");
            double item4 = double.Parse(Console.ReadLine());

            Console.Write("digite o valor do quinto item:");
            double item5 = double.Parse(Console.ReadLine());

            double soma = (item1 + item2 + item3 + item4 + item5);
            Console.WriteLine($"{soma:F2}");

            Console.Write("digite o valor recebido:");
            double valor_recebido = double.Parse(Console.ReadLine());


            double valor_a_ser_pago = item1 + item2 + item3 + item4 + item5;
            double troco = valor_recebido - valor_a_ser_pago;


            Console.WriteLine($"O valor a ser pago é: R$ {valor_a_ser_pago:F2} e o troco é: R$ {troco:F2}");
        }
    }
}
