using System;
using Atividade_Herança_e_Polimorfismo.Entities;

namespace Atividade_Herança_e_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Imovel imovel1 = new ImovelNovo();
             Imovel imovel2 = new ImovelVelho();
             double valorMetro;
             double metrosQuadrado;
          
            
             Console.WriteLine("Qual o tipo de imóvel desejado? \nDigite: Novo(1) ou Usado(2). ");
             int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                Console.WriteLine("Digite o endereço do imóvel: ");
                imovel1.Endereco = Console.ReadLine();
                Console.WriteLine("Digite o valor do metro quadrado: ");
                valorMetro = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantos metros quadrados deseja que seu imóvel possua?");
                metrosQuadrado = double.Parse(Console.ReadLine());
                imovel1.CalcularValor(valorMetro, metrosQuadrado);
                Console.WriteLine(imovel1);

            }
            else if (opt == 2)
            {
                Console.WriteLine("Digite o endereço do imóvel: ");
                imovel2.Endereco = Console.ReadLine();
                Console.WriteLine("Digite o valor do metro quadrado: ");
                valorMetro = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantos metros quadrados deseja que seu imóvel possua? ");
                metrosQuadrado = double.Parse(Console.ReadLine());
                imovel2.CalcularValor(valorMetro, metrosQuadrado);
                Console.WriteLine(imovel2);
            }
            else
            {
                Console.WriteLine("O Valor inserido é inválido! \nDigite um valor valido!");
            }
            

             
            
        }
    }
}
