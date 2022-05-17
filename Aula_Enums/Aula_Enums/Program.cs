using System;
using Aula_Enums.Entities;
using Aula_Enums.Entities.Enums;

namespace Aula_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();

            Console.WriteLine("Digite o número do pedido: ");
            pedido.NumeroPedido = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o item: ");
            pedido.Item = Console.ReadLine();

            pedido.Data = DateTime.Now;

            Console.WriteLine("Digite o estado do pedido: ");
            int opt = int.Parse(Console.ReadLine());
            pedido.PedidoStatus = (EstadoPedido)opt;

            Console.WriteLine(pedido);


            long cpf = 05782217138;
            Console.WriteLine(cpf.ToString(@"000\.000\.000\-00"));




        }
    }
}
