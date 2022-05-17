using System;
using System.Collections.Generic;
using System.Text;

namespace Revisão_Aula_13_05_2022
{
    internal class Soma
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public int N4 { get; set; }

        public Soma()
        {

        }
       

        public Soma(int n1, int n2)
        {
            N1 = n1;
            N2 = n2;
            
        }

        public Soma(int n1, int n2, int n3, int n4) : this(n1, n2)
        {
            N3 = n3;
            N4 = n4;
        }


        public override string ToString()
        {
            return "A soma é:  " + (N1 + N2 + N3 + N4);
        }

    }

    
}
