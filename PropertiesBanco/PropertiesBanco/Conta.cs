using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesBanco
{
    internal class Conta
    {
        public int NumeroConta { get; set; }

        public int Agencia { get; set; }

        public string Nome { get; set; }

        public double Saldo { get; private set; }



    }
}
