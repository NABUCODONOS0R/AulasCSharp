using System;
using InterfaceExplicacaoSimples_30_05_2022.Entities;

namespace InterfaceExplicacaoSimples_30_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro; //não precisa do new carro porque é uma classe abstrata.
            Console.WriteLine("================ CONCESSIONÁRIA FULANO DE TAL ==========================");
            Console.WriteLine("Pressione a tecla (s) para Sedan ou a tecla (h) para hatch. ");

            var tipoEscolhido = Console.ReadLine().ToUpper();

            try
            {
                if(tipoEscolhido.Equals("S"))
                {
                    carro = new CarroSedan();
                }
                else if(tipoEscolhido.Equals("H"))
                {
                    carro = new CarroHatch();

                }
                else
                {
                    Console.WriteLine("O tipo informado é inválido. ");
                    return;

                }

                carro.PrepararTransporte();
                carro.Transportar();
                carro.Entregue();

            }
            catch
            {
                Console.WriteLine("ops! Algo de errado aconteceu. ");
            }


        }

    }

}
