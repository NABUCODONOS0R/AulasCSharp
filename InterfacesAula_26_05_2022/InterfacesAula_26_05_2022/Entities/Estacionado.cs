using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAula_26_05_2022.Entities
{
    internal class Estacionado
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public Carro Carro { get; set; }
        public Fatura Fatura { get; set; }

        public Estacionado(DateTime entrada, DateTime saida, Carro carro)
        {
            Entrada = entrada;
            Saida = saida;
            Carro = carro;
        }

    }
}
