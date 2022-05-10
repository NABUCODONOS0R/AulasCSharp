using System;

namespace atividadedado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dado = new Random();

            int dado1 = dado.Next(1, 7);
            int dado2 = dado.Next(1, 7);
            int dado3 = dado.Next(1, 7);


            int total = dado1 + dado2 + dado3;
            Console.WriteLine("Dado 1 " + dado1);
            Console.WriteLine("Dado 2 " + dado2);
            Console.WriteLine("Dado 3 " + dado3);

            if((dado1 == dado2) || (dado1 == dado3) || (dado2 == dado3))
            {
                if((dado1 == dado2) && (dado2 == dado3))
                {
                    total = total + 3;
                    Console.WriteLine("Parabéns! Você ganhou mais 3 pontos de bônus. ");
                }
                else
                {
                    total = total + 2;
                    Console.WriteLine("Parabéns! Você ganhou mais 2 pontos de bônus. ");

                }
            }
            if(total >= 16)
            {
                Console.WriteLine("Parabéns! Você ganhou! Total de pontos:  " + total);

            }
            else
            {
                Console.WriteLine("Infelizmente não foi dessa vez. Total de pontos {}. Tente novamente.",total);
            }
        }
    }
}
