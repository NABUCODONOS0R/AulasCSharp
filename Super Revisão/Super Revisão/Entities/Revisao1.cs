using System;
using System.Collections.Generic;
using System.Text;

namespace Super_Revisão.Entities
{
    internal class Revisao1 : Revisao //herdando atributos e métodos da classe Revisão
    {
        public Revisao1()
        {

        }

        public Revisao1(string endereco, double valor) : base(endereco, valor)
        {
            
        }

        public override void CalculoVenda(double valorMetro, double metrosQuad) 
        {
            base.CalculoVenda(valorMetro, metrosQuad);
            Valor = valorMetro * metrosQuad - (valorMetro * metrosQuad * (0.10)); // menos 10% por ser usado
        }


    }


}
