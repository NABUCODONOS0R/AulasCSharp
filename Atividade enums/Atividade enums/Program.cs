using System;
using Atividade_enums.Entities;
using Atividade_enums.Entities.Enums;

namespace Atividade_enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();

            Console.WriteLine("Digite o nome do pedido: ");
            pedido.NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de itens: ");
            pedido.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário: ");
            pedido.ValorUnitario = double.Parse(Console.ReadLine());

            pedido.Data = DateTime.Now;
            Console.WriteLine("\n");
            Console.WriteLine("Valor total R$ " + pedido.ValorTotal().ToString("F2"));
            Console.WriteLine("\n");
            Console.WriteLine("Digite o estado do pedido: ");
            int opt = int.Parse(Console.ReadLine());
            pedido.PedidoStatus = (EstadoPedido)opt;
            Console.WriteLine("\n");
            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");
            Console.WriteLine(pedido);
            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");
        }
    }
}
