using System;
using System.Collections.Generic;
using System.Text;

namespace Super_Revisão.Entities
{
    internal class Revisao2 : Revisao //herdando atributos e métodos da classe Revisão
    {
        public Revisao2()
        {

        }

        public Revisao2 (string endereco, double valor) : base(endereco, valor)
        {

        }

        public override void CalculoVenda(double valorMetro, double metrosQuad)
        {
            base.CalculoVenda(valorMetro, metrosQuad);
            Valor = valorMetro * metrosQuad + (valorMetro * metrosQuad * (0.10)); //mais 10% por ser novo
        }

    }
}
