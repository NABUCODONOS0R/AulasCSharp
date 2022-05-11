using System;

namespace AtividadeConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char opcao;

            do
            {
                Conta conta = new Conta();

                Console.Write("Digite o nome do usuário da conta: ");
                conta.Nome = Console.ReadLine();

                Console.Write("Digite o número da agência: ");
                conta.Agencia = int.Parse(Console.ReadLine());

                Console.Write("Digite o número da conta: ");
                conta.NumeroConta = int.Parse(Console.ReadLine());

                Console.Write("Deseja realizar um deposito? \nDigite s (sim) ou n (não). ");
                opcao = char.Parse(Console.ReadLine());

                double valor = 0;
                if (opcao == 's')
                {
                    Console.Write("Digite o valor do depósito: ");
                    valor = double.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                }

                Console.Write("Deseja realizar um saque? \nDigite s (sim) ou n (não).");
                opcao = char.Parse(Console.ReadLine());

                if (opcao == 's')
                {
                    Console.Write("Digite a quantia do saque: ");
                    valor = double.Parse(Console.ReadLine());

                    if (conta.Saldo >= valor)
                    {
                        conta.Sacar(valor);
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente! \nSaldo atual R$ " + conta.Saldo.ToString("F2"));
                    }
                }

                Console.WriteLine(conta);

                Console.WriteLine("Deseja realizar outra operação?  \nDigite s (sim) ou n (não). ");
                opcao = char.Parse(Console.ReadLine());
            } while (opcao == 's');



        }

       
    }
}
