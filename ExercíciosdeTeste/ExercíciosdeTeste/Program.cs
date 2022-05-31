using System;

namespace ExercíciosdeTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //IMPRIMIR A DATA E A HORA ATUAL DO SISTEMA.
            DateTime agora = DateTime.Now;
            Console.WriteLine(agora);


            //CALCULAR A DATA DE NASCIMENTO DE UMA PESSOA.
            Console.WriteLine("Digite a sua data de nascimento: ");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            DateTime ano = DateTime.Now;
            int anosIdade = ano.Year - dataNasc.Year;
           
            if(dataNasc.Month < ano.Month)
            {
                Console.WriteLine(anosIdade);
            }
            else
            {
                Console.WriteLine(anosIdade - 1);
            }



            //SIMULAR A ENTRADA E SAÍDA DE UM VEÍCULO E GERAR UM VALOR POR TEMPO DE PRMANÊNCIA.
            Console.WriteLine("Digite a data e a hora de entrada: ");
            DateTime entrada = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a da e a hora de saída: ");
            DateTime saida = DateTime.Parse(Console.ReadLine());
            TimeSpan tempoPermanencia = saida.Subtract(entrada);
            
            Console.WriteLine("Você utilizou o estacionamento por {0} minutos :" , tempoPermanencia.TotalMinutes);
            double valorCobrado = tempoPermanencia.TotalMinutes * 0.10;
            Console.WriteLine("Valor total {0} ", valorCobrado.ToString("C2"));
        }
    }
}
