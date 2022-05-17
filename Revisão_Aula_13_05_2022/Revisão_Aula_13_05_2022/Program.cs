using System;

namespace Revisão_Aula_13_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Soma soma = new Soma() { N1 = 7, N2 = 9, N3 = 9, N4 = 7};
           
            Console.WriteLine(soma);
        }
    }
}
