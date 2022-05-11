using System;

namespace Aula_10_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Nullable
            double? x = null;
            double? b = x ?? 9.36; // ??verifica se é nulo e se for ele vira 9,36
            Console.WriteLine(x);

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            //Console.WriteLine(x.Value);
            Console.WriteLine(b.Value);*/

            //Params

            Console.WriteLine(Calculadora.Somar(3, 6, 9, 12, 15, 18));
           
            








        }
    }



}
