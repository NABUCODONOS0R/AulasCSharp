using System;

namespace Atividade_DataTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime agora = DateTime.Now;
            Console.WriteLine(agora);


            Console.WriteLine("\n==================================================");
            Console.WriteLine("Digite a sua data de nascimento: ");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            DateTime ano = DateTime.Now;
            Console.WriteLine("Você tem {0} anos de idade. ",ano.Year - dataNasc.Year);



            Console.WriteLine("\n==================================================");
            DateTime entrada = new DateTime(2022, 05, 19, 19, 24, 00);
            DateTime saida = new DateTime(2022, 05, 19, 23, 15, 00);
            TimeSpan tempoPermanencia = saida.Subtract(entrada);
            Console.WriteLine("Você utilizou o estacionamento por {0} : " , tempoPermanencia);
            double valorCobrado = tempoPermanencia.TotalMinutes * 0.10;
            Console.WriteLine("Valor total {0} ", valorCobrado.ToString("C2"));
        }
    }
}
