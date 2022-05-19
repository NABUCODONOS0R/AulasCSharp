using System;
using System.Collections.Generic;
using System.Text;
using Atividade2Enums.Entities.Enums;

namespace Atividade2Enums.Entities
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public Cambio TipoCambio { get; set; }
        public Combustivel TipoCombustivel { get; set; }


        public Carro()
        {

        }

        public Carro(string marca, string modelo, int ano, string cor, Cambio tipoCambio, Combustivel tipoCombustivel)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            TipoCambio = tipoCambio;
            TipoCombustivel = tipoCombustivel;

        }


        public void TipoComb(int comb)
        {
            if (comb <= 7 && comb >= 0)
            {
                TipoCombustivel = (Combustivel)comb;
            }
            else
            {
                System.Console.WriteLine("Tipo de combustivel invalido!");
            }

        }
        public void TipoCamb(int camb)
        {
            if (camb <= 3 && camb >= 0)
            {
                TipoCambio = (Cambio)camb;
            }
            else
            {
                System.Console.WriteLine("Tipo de cambio invalido!");
            }


        }

       
        public override string ToString()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo + "\nCor: " + Cor + "\nAno: " + Ano + "\nTipo de Câmbio: " + TipoCambio + "\nTipo Combustível: " + TipoCombustivel;
        }

    }
}
