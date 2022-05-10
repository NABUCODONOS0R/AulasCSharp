using System;

namespace exercicio2__funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com um numero: ");
            int numero = int.Parse(Console.ReadLine());

            PositivoOuNegativo(numero);

            Console.WriteLine(PositivoOuNegativo(numero));

        }
        static string PositivoOuNegativo(int n)
        {
            if (n > 0)
            {
                return "P";
            }
            else if(n < 0)
            {
                return "N";
            }
            else
            {
                return "Elemento Neutro";
            }
        }
    }
}
