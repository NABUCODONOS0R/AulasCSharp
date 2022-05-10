using System;

namespace atividade_dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o valor atual do dólar: ");
            double dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor para a conversão para real: ");
            double reais = double.Parse(Console.ReadLine());

            double valor = Conversao(dolar);

            Console.WriteLine("O valor é R$ {0}", valor);

        }
        static double Conversao(double x)
        {

            return x * reais;
        }
    }
}
