using System;

namespace PropertiesBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            char opcao;
            do
            {
                Console.Write("Digite seu nome completo: ");
                conta.Nome = Console.ReadLine();
                Console.Write("Digite o número da agência: ");
                conta.Agencia = int.Parse(Console.ReadLine());
                Console.Write("Digite o número da conta: ");
                conta.NumeroConta = int.Parse(Console.ReadLine());

                Console.Write("Deseja realizar um depósito? \nDigite: s (sim) ou n (não). ");
                opcao = char.Parse(Console.ReadLine());
                double valor = 0;

                if (opcao == 's')
                {
                    Console.Write("Digite o valor a ser depositado: ");
                    valor = double.Parse(Console.ReadLine());
                    conta.Depositar(valor);

                }



                Console.Write("Deseja realizar um saque? \nDigite: s (sim) ou n (não). ");
                opcao = char.Parse(Console.ReadLine());

                if (opcao == 's')
                {
                    Console.WriteLine("Digite o valor do saque: ");
                    valor = double.Parse(Console.ReadLine());

                    if (conta.Saldo >= valor)
                    {
                        conta.Sacar(valor);
                    }
                    else
                    {
                        Console.Write("Saldo insuficiente! \nSaldo atual: R$ {0:F2}", conta.Saldo);
                    }
                }

                Console.WriteLine(conta);
                Console.WriteLine("Deseja realizar outra operação ? \nDigite: s (sim) ou n (não). ");
                opcao = char.Parse(Console.ReadLine());

            } while (opcao == 's');




        }
    }
}
