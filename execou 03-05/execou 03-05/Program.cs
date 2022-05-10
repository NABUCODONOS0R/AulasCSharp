using System;

namespace execou_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota = 0;

            do
            {


                if (nota == 0.00 && nota <= 10.00)
                {
                    Console.WriteLine("Por favor, digite uma nota válida: ");

                }

                Console.WriteLine("Digite uma nota de 0 a 10: ");
                nota = double.Parse(Console.ReadLine());


            }
            while (nota > 10.00 && nota < 0.00);
                {
                    Console.WriteLine("O valor atribuído é válido: ");
                }

              
            
        }
    }
}
