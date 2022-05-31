using System;
using Aula_27_05_2022_Polimorfismo.Entities;

namespace Aula_27_05_2022_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            Conta cc = new ContaCorrente();
            Conta cp = new ContaPoupanca();

            conta.Depositar(200.00);
            cc.Depositar(500.00);
            cp.Depositar(900.00);

            Console.WriteLine("Saldo da classe conta: " + conta.Saldo.ToString("C2"));
            Console.WriteLine("Saldo da conta corrente: " + cc.Saldo.ToString("C2"));
            Console.WriteLine("Saldo da conta poupança: " + cp.Saldo.ToString("C2"));

            conta.Sacar(100.00);
            cc.Sacar(100.00);
            cp.Sacar(100.00);
            Console.WriteLine("\nDepois do saque: \n");

            Console.WriteLine("Saldo da classe conta: " + conta.Saldo.ToString("C2"));
            Console.WriteLine("Saldo da conta corrente: " + cc.Saldo.ToString("C2"));
            Console.WriteLine("Saldo da conta poupança: " + cp.Saldo.ToString("C2"));
        }
    }
}
