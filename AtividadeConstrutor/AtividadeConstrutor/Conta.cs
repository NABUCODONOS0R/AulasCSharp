using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeConstrutor
{
    internal class Conta
    {
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public string Nome { get; set; }
        public double Saldo{ get; private set; }

        public Conta()
        {

        }

        public Conta(int numeroConta, int agencia, string nome)
        {
            NumeroConta = numeroConta;
            Agencia = agencia;
            Nome = nome;

        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return "Usuário da Conta: " + Nome + "\nAgencia: " + Agencia + "\nConta: " + NumeroConta + "\nSaldo R$ " + Saldo.ToString("F2");

        }





    }
}
