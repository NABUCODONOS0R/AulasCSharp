using System;
using System.Collections.Generic;
using System.Text;

namespace Super_Revisão.Entities
{
    internal class Revisao
    {
        public string Endereco { get; set; }
        public double Valor { get; set; }

        public Revisao()
        {

        }

        public Revisao(string endereco, double valor)
        {
            Endereco = endereco;
            Valor = valor;
        }

        public virtual void CalculoVenda(double valorMetro, double metrosQuad)
        {
            Valor = valorMetro * metrosQuad;
        }

        public override string ToString()
        {
            return "Endereço do Imóvel: " + Endereco + "\nValor do Imóvel: " + Valor.ToString("C2");
        }
    }
}
