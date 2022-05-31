using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_27_05_2022_Polimorfismo.Entities
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca()
        {

        }

        public ContaPoupanca(string titularConta) : base(titularConta)//os mesmos parâmetros do construtor da classe conta
        {
        }

        public override void Sacar(double valor)//Polimorfismo. override para sobrescrever esse método virtual da classe conta
        {
            Saldo -= valor;
        }
    }
}
