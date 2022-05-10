using System;

namespace Atividade2_aula_02_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Produto produto1, produto2, produto3;
            produto1 = new Produto();
            produto2 = new Produto();
            produto3 = new Produto();




            Console.WriteLine("Digite o Nome do produto: ");
            produto1.NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o preço de custo: ");
            produto1.PrecodeCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de venda: ");
            produto1.PrecodeVenda = double.Parse(Console.ReadLine());



            Console.WriteLine("Digite o Nome do produto: ");
            produto2.NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o preço de custo: ");
            produto2.PrecodeCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de venda: ");
            produto2.PrecodeVenda = double.Parse(Console.ReadLine());



            Console.WriteLine("Digite o Nome do produto: ");
            produto3.NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o preço de custo: ");
            produto3.PrecodeCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de venda: ");
            produto3.PrecodeVenda = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome do produto: " +  produto1.NomeProduto + "  Preço de Custo: " + produto1.PrecodeCusto + 
                "preço de Venda:  " + produto1.PrecodeVenda );

            Console.WriteLine("Nome do produto: " + produto2.NomeProduto + "  Preço de Custo: " + produto2.PrecodeCusto + 
              "preço de Venda:  " + produto2.PrecodeVenda);

            Console.WriteLine("Nome do produto: " + produto3.NomeProduto +  "  Preço de Custo: " + produto3.PrecodeCusto +
              "preço de Venda:  " + produto3.PrecodeVenda);





        }
    }
}
