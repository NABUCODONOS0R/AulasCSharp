using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_10_05_2022
{
    internal class Calculadora
    {
        public static int Somar(params int[] numeros)
        {
            int soma = 0;

            for(int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }


    }
}
