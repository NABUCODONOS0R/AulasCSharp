using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExplicacaoSimples_30_05_2022.Entities
{
    abstract internal class Carro//abstract permite que os métodos sejam passados vazio.
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public abstract void PrepararTransporte();

        public abstract void Transportar();

        public abstract void Entregue();



    }
}
