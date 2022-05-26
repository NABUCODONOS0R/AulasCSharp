using System;
using System.Collections.Generic;
using System.Text;
using Aula_Exception_23_05_2022.Entities.Exceptions;

namespace Aula_Exception_23_05_2022.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        Produto()
        {

        }

        public Produto(string nome, int quantidade, double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }

        public void VerificarErro(string nome)
        {
            if(nome.Length < 3)//se o nome for menor que 3 caracteres.
            {
                throw new ExcecaoProduto("O nome não pode conter menos que 3 caracteres. ");//retorna essa frase.
            }

        }

        public void VerificarErro(int quantidade)
        {
            if(quantidade <= 0)
            {
                throw new ExcecaoProduto("O número da quantidade não pode ser menor ou igual a zero. ");
            }

        }
        public override string ToString()
        {
            return "Nome do produto: " + Nome + "\nQuantidade cadastrada: " + Quantidade + "\nValor unitário: " + Valor.ToString("C2");
        }
    }
}
