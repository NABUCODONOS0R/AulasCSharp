using System;
using System.Collections.Generic;
using System.Text;

namespace REVISS
{
    internal class Revisando
    {

        public int N1;
        public int N2;
        public int N3;
        public int N4;
        public string Op1;
        public string Op2;

        public Revisando()
        {

        }

        public Revisando(string op1, string op2,int n1, int n2, int n3, int n4 )
        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
            N4 = n4;
            Op1 = op1;
            Op2 = op2;
        }

        public string Calculo1()
        {
            if (Op1 == "+")
            {
                return "Operação de Soma escolhida: " + (N1 + N2 + N3 + N4);
            }
            else if (Op1 == "*")
            {
                return "Operação de multiplicação escolhida: " + (N1 * N2 * N3 * N4);
            }
            else if (Op1 == "/")
            {
                if (N2 == 0 || N4 == 0)
                {
                    return "O valor do segundo número não pode ser iguala zero na operação de divisão! \nRetorne um númeroválido para segunda opção ";
                }
                else
                {
                    return "Operação de Divisão escolhida: " + (N1 /N2) + "\nResultado 2: " + (N3 / N4);
                }
            }
            else 
            { 

                return "Retorne um operador válido!";
            }
        }

        public string Calculo2()
        {
            if (Op2 == "+")
            {
                return "Operação de Soma escolhida: " + (N1 + N2);
            }
            else if (Op2 == "*")
            {
                return "Operação de multiplicação escolhida: " + (N1 * N2);
            }
            else if (Op2 == "/")
            {
                if (N2 == 0 || N4 == 0)
                {
                    return "O valor do segundo número não pode ser iguala zero na operação de divisão! \nRetorne um númeroválido para segunda opção ";
                }
                else
                {
                    return "Operação de Divisão escolhida: " + (N1 / N2) + "\nResultado 2: " + (N3 / N4);
                }
            }
            else
            {

                return "Retorne um operador válido!";
            }
        }

       



    }





    
}
