using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesBanco
{
    internal class Conta
    {
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

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
            return "Usuário: " + Nome + "\nAgência: " + Agencia + "\nNúmero da Conta: " + NumeroConta + "\nSaldo R$ " + Saldo.ToString("F2");
        }



    }


}
