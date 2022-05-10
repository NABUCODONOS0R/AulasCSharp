using System;

namespace Exercício_Aula_03_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsuarioBanco dados = new UsuarioBanco();

            Console.WriteLine("Digite o nome: ");
            dados.Id = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            dados.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta: ");
            dados.NumeroDaConta = long.Parse(Console.ReadLine());
            Console.WriteLine("Digite o saldo: ");
            dados.Saldo = double.Parse(Console.ReadLine());


        }
    }
}
