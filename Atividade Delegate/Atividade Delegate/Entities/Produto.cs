using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Delegate.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;

        }

       


    }
}
