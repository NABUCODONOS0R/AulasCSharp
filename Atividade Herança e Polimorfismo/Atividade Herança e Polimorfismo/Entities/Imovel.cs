using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Herança_e_Polimorfismo.Entities
{
    internal class Imovel
    {
        public string Endereco { get; set; }
        public double Valor { get; set; }
       
        


        public Imovel()
        {

        }


        public Imovel(string endereco, double valor)
        {
            Endereco = endereco;
            Valor = valor;
        }

       

    
        public virtual void CalcularValor(double preco, double metroQuadrado)
        {

            Valor = preco * metroQuadrado;
            
        }

        public override string ToString()
        {
            return "Endereço do imóvel: " + Endereco + "\nValor do imóvel: " + Valor.ToString("C2");
        }
    }
}
