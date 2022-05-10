using System;

namespace Atividade_aula_assincrona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular soma, divi, mult = new Calcular();

            Console.WriteLine("Digite 2 números inteiros: ");
            soma.N1 = int.Parse(Console.ReadLine());
            soma.N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 2 números inteiros: ");
            divi.N1 = int.Parse(Console.ReadLine());
            divi.N2 = int.Parse(Console.ReadLine());
            mult.N1 = int.Parse(Console.ReadLine());
            mult.N2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma  é: {0} ",soma.Soma());
            Console.WriteLine("A divisão é {0:F2} ",div.Divisao());
                
        }
    }
}
