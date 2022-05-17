using System;
using System.Collections.Generic;
using System.Text;
using Aula_Enums.Entities.Enums;

namespace Aula_Enums.Entities
{
    internal class Pedido
    {
        public int NumeroPedido { get; set; }
        public string Item { get; set; }
        public DateTime Data { get; set; }
        public EstadoPedido PedidoStatus { get; set; }


        public override string ToString()
        {
            return "Número do pedido: " + NumeroPedido + "\nItem: " + Item + "\nData: " + Data + "\nEstado do pedido: " + PedidoStatus;
        }


    }
}
