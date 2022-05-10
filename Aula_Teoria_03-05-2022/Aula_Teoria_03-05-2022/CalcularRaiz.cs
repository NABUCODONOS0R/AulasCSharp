using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_Teoria_03_05_2022
{
     class CalcularRaiz
    {
        public double A;
        public double B;
        public double C;


        public double Delta()
        {
            return Math.Pow(B, 2) - 4 * A * C;
        }


        public double X1()
        {
            return - B + (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C) / (2 * A));
        }

        public double X2()
        {
            return - B - (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C) / (2 * A));
        }

        /*public double X2()
        {
            return (-B - Math.Sqrt(Delta()) / (2 * A));
        }


        */


    }
}
