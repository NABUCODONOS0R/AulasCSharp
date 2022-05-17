using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_herança
{
    internal class ContaPoupanca : Conta
    {
        public double Rendimento{ get; set; }
        

        public ContaPoupanca()
        {

        }

        public ContaPoupanca(string nome, int numeroConta, double rendimento) : base (nome, numeroConta)
        {
            Rendimento = rendimento;
        }


        public void Rendimentos(double valor)
        {
            Saldo += valor;
        }


    }
}
