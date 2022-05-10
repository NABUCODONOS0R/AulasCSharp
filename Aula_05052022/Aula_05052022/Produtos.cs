using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_05052022
{
    internal class Produtos
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produtos()
        {

        }

        public Produtos(int quantidade)
        {
            Quantidade = quantidade;
        }

        public Produtos(int quantidade, string nome, double preco)
        {
            Quantidade = quantidade;
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return "\nNome: " + Nome +  "\nPreço: " + Preco +  " \nQuantidade: " + Quantidade;
        }





    }
}
