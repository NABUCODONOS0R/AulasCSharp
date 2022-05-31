using System;
using System.Collections.Generic;
using Atividade_Delegate.Entities;
using System.Linq;

namespace Atividade_Delegate
{
    

    internal class Program
    {
        

        static void Main(string[] args)
        {
            Produto produto = new Produto();

            List<Produto> produtos = new List<Produto>();
            char opt;

            do
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());
                double desconto = (preco - (preco * 0.10));

                produtos.Add(new Produto(nome, preco, desconto));

                Console.WriteLine("Produto cadastrado. \nDeseja realizar outro cadastro? \nDigite: (s)Sim ou (n)Não.");
                opt = char.Parse(Console.ReadLine());

            } while (opt == 's' || opt == 'S');

            List<string> resultado = produtos.Select(CaixaAlta).ToList();
            List<string> resultado2 = produtos.Select(Desconto).ToList();

            foreach (string result in resultado)
            {
                Console.WriteLine(result);
            }

            foreach(string result2 in resultado2)
            {
                Console.WriteLine(result2);
            }

        }

        static string CaixaAlta(Produto produto2)
        {
            return "Nome do produto: " + produto2.Nome.ToUpper();//retorna os nomes em caixa alta
        }

        static string Desconto(Produto desconto)
        {
            return "Preco com 10% de desconto" + (desconto.Desconto).ToString("C2");
        }
    }
}
