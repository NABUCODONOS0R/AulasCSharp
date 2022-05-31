using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_27_05_2022_Polimorfismo.Entities
{
    internal class Conta
    {
        public string TitulaConta { get; set; }
        public double Saldo { get; protected set; }//protected para poder ser acessado nas classes herdantes

        public Conta()
        {

        }
        public Conta(string titularConta)
        {
            TitulaConta = titularConta;
        }


        public virtual void Sacar(double valor)//Virtual pode ser modificado no mesmo assembly 
        {
            Saldo -= valor + 2;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
