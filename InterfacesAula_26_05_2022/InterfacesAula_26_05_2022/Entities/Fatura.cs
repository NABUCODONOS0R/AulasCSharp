using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAula_26_05_2022.Entities
{
    internal class Fatura
    {
        public double Valor { get; set; }
        public double Imposto { get; set; }

        public Fatura(double valor, double imposto)
        {
            Valor = valor;
            Imposto = imposto;
        }
        public double ValorTotal
        {
            get { return Valor + Imposto; }
        }

        public override string ToString()
        {
            return "Valor gerado: " + Valor.ToString("F2") + "\nImposto: " + Imposto.ToString("F2") + "\nTotal a ser pago: " + ValorTotal.ToString("F2");

        }
    }
}
