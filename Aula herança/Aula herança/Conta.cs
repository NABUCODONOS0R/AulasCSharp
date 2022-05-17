using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_herança
{
    internal class Conta
    {
        public string Nome { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; protected set; }

        public Conta()
        {

        }
        
        public Conta(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }




    }
}
