using System;

namespace Exercício_array_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[5] { 3, 6, 9, 21, 33 }; //ler um vetor de 5 números inteiros e imprimi-los.
            
            for(int contador = 0; contador < numeros.Length; contador++)
            {
                Console.WriteLine(numeros [contador]);
            }



            double[] notas = new double[4] {7.95, 8.86, 7.45, 9.33 };
            
            for(int contador1 = 0; contador1 < notas.Length; contador1++)
            {
                Console.WriteLine(notas [contador1]);
            }

            Console.WriteLine();

            




        }
    }
}
