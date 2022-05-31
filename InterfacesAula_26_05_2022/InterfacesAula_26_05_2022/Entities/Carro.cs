using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAula_26_05_2022.Entities
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

        public Carro(string modelo, string marca, string placa)
        {
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
        }

    }
}
