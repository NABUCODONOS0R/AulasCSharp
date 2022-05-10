using System;

namespace Exercícios_Pendentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int x, y, z;
           Console.WriteLine("Entre com 3 números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());


            int resultado = Maior (x, y, z);
            Console.WriteLine("{0} é o maior número. ",resultado);


        }

        static int Maior(int a, int b, int c)
        {
            int maior = 0;
            if(a > b && a > c)
            {
                maior = a;

            }
            else if (b > a && b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }
            return maior;
        }

       

        




    }



}
