using System;
using Super_Revisão.Entities; //importando para utilizar todas as classes

namespace Super_Revisão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Revisao imovel1 = new Revisao1(); //instância classe Revisão1
            Revisao imovel2 = new Revisao2(); //instância classe Revisão2
            double valorMetro = 0.00;
            double metroQuadrado = 0.00;

            Console.WriteLine("Qual tipo de imóvel desejado? \nDigite: (1)Novo ou (2)Usado.");
            int opt = int.Parse(Console.ReadLine());

            if(opt == 1)
            {
                Console.WriteLine("Digite o endereço do imóvel: ");
                imovel2.Endereco = Console.ReadLine();
                Console.WriteLine("Digite o valor por metro quadrado: ");
                valorMetro = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantos metros deseja que sua casa possua? ");
                metroQuadrado = double.Parse(Console.ReadLine());
                imovel2.CalculoVenda(valorMetro, metroQuadrado); //utilizando método da classe revisão2
                //e passando daqui da classe principal os parâmetros solicitados na classe Revisão2
                Console.WriteLine(imovel2);

            }
            else if(opt == 2)
            {
                Console.WriteLine("Digite o endereço do imóvel: ");
                imovel1.Endereco = Console.ReadLine();
                Console.WriteLine("Digite o valor por metro quadrado: ");
                valorMetro = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantos metros deseja que sua casa possua? ");
                metroQuadrado = double.Parse(Console.ReadLine());
                imovel1.CalculoVenda(valorMetro, metroQuadrado);//utilizando método da classe revisão1
                //e passando daqui da classe principal os parâmetros solicitados na classe Revisão1
                Console.WriteLine(imovel1);

            }
            else
            {
                Console.WriteLine("O tipo de imóvel escolhido está inválido.");
            }
            

        }

       
    }
}
