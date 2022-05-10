using System;

namespace Atividade_29_04_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double preco = 0.0;
            do
            {
                Console.WriteLine("Digite o valor do produto: ");
                preco = double.Parse(Console.ReadLine());
            }
            while (preco <= 0.0);


            double margem = CalculoMargem(preco);
            double imposto = CalculoImposto(preco);
           

            Console.WriteLine("O valor com 40% de margem de lucro é R$ {0:F2}", (margem) + (preco));
            Console.WriteLine("O valor com 5% de imposto é de R$ {0:F2}", (imposto) + (preco) + (margem));
            Console.WriteLine("O valor total é R$ {0:F2}", (margem) + (imposto) + (preco));
            Console.WriteLine("O valor sem o imposto é R$ {0:F2}",  (preco) + (margem));
        }

        static double CalculoMargem(double x)
        {
            return x * 0.4;
        }

        static double CalculoImposto(double y)
        {
            return y * 0.05;
        }
    }
}
