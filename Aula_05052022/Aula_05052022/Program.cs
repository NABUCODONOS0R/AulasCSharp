using System;

namespace Aula_05052022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o Nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o Preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Produtos prod = new Produtos() { Nome = nome, Preco = preco, Quantidade = 3 };
            Console.WriteLine(prod);
        }
    }
}
