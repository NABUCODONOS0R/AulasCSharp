using System;

namespace Atividade_Pendente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.WriteLine("Digite o nome : ");
            conta.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            conta.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Seu saldo atual é de R$ {0:F2} ",conta.Saldo);
            Console.WriteLine("Digite o valor a ser depositado: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine("Seu saldo atual é de R$ {0:F2} ",conta.Saldo);
            Console.WriteLine("Digite o valor que deseja sacar: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Nome: {0} ", conta.Nome);
            Console.WriteLine("Idade: {0}: ", conta.Idade);
            Console.WriteLine("Número da Conta: {0} ", conta.NumeroConta);
            Console.WriteLine("Saldo: R$ {0} ",conta.Saldo);

        }
    }
}
