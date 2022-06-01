using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExplicacaoSimples_30_05_2022.Entities
{
    internal class CarroHatch : Carro
    {
        public CarroHatch()
        {
            Tipo = "Hatch";
            Marca = "Hiunday";
            Modelo = "Hb20";
        }



        public override void PrepararTransporte()
        {
            Console.WriteLine($"O veículo {Marca} - {Modelo} tipo: {Tipo} está sendo preparado para entrega. ");
        }



        public override void Transportar()
        {
            Console.WriteLine($"O veículo ({Marca}, {Modelo}) está sendo transportado, prazo para entrega de 6 dias. ");
        }



        public override void Entregue()
        {
            Console.WriteLine("Veículo entregue à concessionária. ");
            Console.WriteLine($"Detalhes do veículo: \nMarca: {Marca} \nModelo: {Modelo} Tipo: {Tipo} ");

        }
    }
}
