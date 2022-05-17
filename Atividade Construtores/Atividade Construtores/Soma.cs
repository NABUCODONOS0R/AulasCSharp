using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Construtores
{
    internal class Soma
    {
        
        public int X;
        public int Y;
        public int A;
        public int C;
        public double X1;

        public Soma()
        {

        }
        public Soma(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Soma(int x, int y, int c) : this(x, y)
        {
            C = c;
        }
        public Soma(int x, int y, int c, int A) : this(x, y, c)
        {
            C = c;
        }

        public int Somar()
        {
            return X + Y + A + C;
        }

        public Soma(double x, int y)
        {
            X1 = x;
            Y = y;
        }

        public int Somar2(double x, int y)
        {
            X1 = x;
            Y = y;
            return (int)X1 + Y;
        }



    }
}
