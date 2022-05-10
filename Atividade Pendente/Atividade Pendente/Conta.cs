using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Pendente
{
    internal class Conta
    {
        public string Nome;
        public int Idade;
        public double Saldo;
        public int NumeroConta;


        public void Saque(double saque)
        {
            if(Saldo >= saque)
            {
                Saldo = Saldo - saque;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }

        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }
    }
}
