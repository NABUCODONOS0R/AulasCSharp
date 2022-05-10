using System;

namespace funções2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Digite 3 números inteiros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            int total = Soma(x, y, z);
            Console.WriteLine("O resultado da soma é {0}. ",total);

        }

        static int Soma(int a, int b, int c)
        {
            return a + b + c;
        }

    }
}
