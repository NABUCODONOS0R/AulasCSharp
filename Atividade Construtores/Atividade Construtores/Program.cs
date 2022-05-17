using System;

namespace Atividade_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Soma calc = new Soma() { A = 10, C = 90 };

            Console.WriteLine(calc.Somar());
            Console.WriteLine(calc.Somar2(1.5, 2));
        }
    }
}
