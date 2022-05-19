using System;
using Atividade2Enums.Entities;
using Atividade2Enums.Entities.Enums;

namespace Atividade2Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Console.WriteLine("Digite o modelo do veículo: ");
            carro.Modelo = Console.ReadLine();

            Console.WriteLine("Digite a marca do veículo: ");
            carro.Marca = Console.ReadLine();

            Console.WriteLine("Digite a cor do veículo: ");
            carro.Cor = Console.ReadLine();

            Console.WriteLine("Digite o ano do veículo: ");
            carro.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tipo de combustível do veículo: ");
            Console.WriteLine("Escolha: Gasolina (0), Etanol(1), Flex(2), Diesel S10(3), Diesel S500(4), Híbrido(5), Elétrico(6), Biodiesel(7) ");
            int tipoComb = int.Parse(Console.ReadLine());
            carro.TipoComb(tipoComb);

            Console.WriteLine("Digite o tipo de câmbio do veículo: ");
            Console.WriteLine("Escolha: Manual(0), Automático(1), Semi-Automático(2), Sequencial(3) ");
            int tipoCamb = int.Parse(Console.ReadLine());
            carro.TipoCamb(tipoCamb);


            Console.WriteLine(carro);
        }
    }
}
