using System;

namespace atividadedopeixe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade, em quilos, de peixes: ");
            double peso = double.Parse(Console.ReadLine());
            double excesso = peso - 20;
            double multa = excesso * 5;


            if(peso > 20)
            {
                Console.WriteLine("Você está com {0} Kg de excesso e o valor da multa será de R$ {1}. ",excesso,multa);

            }
            else if(peso >= 0 && peso <= 20)
            {
                Console.WriteLine("Você está com a quantidade permitida pelo regulamento de pesca. ");
            }
            else
            {
                Console.WriteLine("A quantidade informada está incorreta. ");
            }








        }


    }



}
