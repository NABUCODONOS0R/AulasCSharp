using System;

namespace Aula_Teoria_03_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CalcularRaiz calc = new CalcularRaiz();

            Console.WriteLine("Digite o valor de a, b e c: ");
            calc.A = double.Parse(Console.ReadLine());
            calc.B = double.Parse(Console.ReadLine());
            calc.C = double.Parse(Console.ReadLine());


            Console.WriteLine("O valor de Delta é: {0:F2} ",calc.Delta());
            Console.WriteLine("O valor de X1 é: {0:F2} ",calc.X1());
            Console.WriteLine("O valor de X2 é: {0:F2} ",calc.X2());



        }
    }
}
