using System;

namespace Atividade_18_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Exercício 01
           DateTime data4 = DateTime.Now;
           Console.WriteLine("Data atual: " + data4);
           string convertida = data4.ToUniversalTime().ToString("yyyy-MM - ddTHH:mm: ssZ");
           Console.WriteLine("Convertida para string como no banco de dados: " + convertida);
           Console.WriteLine("Imprimindo novamente com o parse: " + DateTime.Parse(convertida));
             

            //Exercício 02
            Console.WriteLine("Digite o valor do produto: ");
            double valorProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite em quantas vezes deseja parcelar: ");
            int numeroParcelas = int.Parse(Console.ReadLine());
            string data5 = data4.AddDays(30).ToString("D");
            int meses = numeroParcelas + 1;
            string data6 = data4.AddMonths(meses).ToString("D");


            if (numeroParcelas > 0 && numeroParcelas <= 12)
            {
                Console.WriteLine("O produto foi parcelado em {0} vezes de R$ {1:F2}. ", numeroParcelas, valorProduto / (numeroParcelas));
                Console.WriteLine("A primeira parcela inicia em {0} \nA última parcela será em {1} ",data5, data6);

            }
            else
            {
                Console.WriteLine("O valor de parcelamento informado está incorreto");
            }
           

        }
    }
}
