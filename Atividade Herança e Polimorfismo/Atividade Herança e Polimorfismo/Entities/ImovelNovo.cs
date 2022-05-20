using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Herança_e_Polimorfismo.Entities
{
    internal class ImovelNovo : Imovel
    {
        public ImovelNovo()
        {

        }

        public ImovelNovo(string endereco, double valor) : base(endereco, valor)
        {
        }

        public override void CalcularValor(double preco, double metroQuadrado)
        {
            base.CalcularValor(preco, metroQuadrado);
            Valor = preco * metroQuadrado + (preco * metroQuadrado * (0.10));
        }
    }
}
