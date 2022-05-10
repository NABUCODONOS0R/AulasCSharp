using System;

namespace atv28_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Entre com 3 números inteiros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            int resultado = Maior(x, y, z);
            Console.WriteLine("O maior número é: " + resultado);

            Mensagem("x");

            

        }

        static int Maior(int a, int b, int c)
        {
            int maior = 0;
            if(a > b && a > c)
            {
                maior = a;
            }
            else if(b > c)
            {
                maior = b;

            }
            else
            {
                maior = c;
            }

            return maior;
        }
        static void Mensagem(string a)
        {
            a = "Marcos Mendes";
            Console.WriteLine(a);
        }

        



    }




}
