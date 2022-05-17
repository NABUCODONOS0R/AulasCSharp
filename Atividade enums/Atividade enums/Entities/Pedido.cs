using System;
using System.Collections.Generic;
using System.Text;
using Atividade_enums.Entities.Enums;

namespace Atividade_enums.Entities
{
    internal class Pedido
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public double ValorUnitario { get; set; }
        public EstadoPedido PedidoStatus { get; set; }

        public Pedido()
        {

        }

        public Pedido(string nomeProduto, int quantidade, double valorUnitario)
        {
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;

        }

        public double ValorTotal()
        {
            return Quantidade * ValorUnitario;
           
        }

       



        public override string ToString()
        {
            return "Nome do produto: " + NomeProduto + "\nQuantidade: " +
            Quantidade + "\nValor Unitário R$ " + ValorUnitario.ToString("F2") + "\nData: " + Data + "\nEstado do pedido: " +
            PedidoStatus;
        }
    }
}
