using System;

namespace Revisão
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            int[] numeros = new int[5] {3,6,9,9,3}; //ler 5 números inteiros e mostrá-los
            Console.WriteLine(numeros);






            double [] notas = new double[4]; //ler 4 notas e imprimir a média
            Console.WriteLine("Digite o valor das quatros notas: ");
            Console.WriteLine("Use vírgula para separar as casas decimais (Ex.: 5,9 ; 4,7; etc.):");
            notas[0] = double.Parse(Console.ReadLine());
            notas[1] = double.Parse(Console.ReadLine());
            notas[2] = double.Parse(Console.ReadLine());
            notas[3] = double.Parse(Console.ReadLine());

            double resultado = (notas[0] + notas[1] + notas[2] + notas[3])/4;

            

            if(resultado >= 5.00 && resultado < 11.00)
            {
                Console.WriteLine("Parabéns! Você foi aprovado. ");
                Console.WriteLine("O valor da sua média é de {0:F2} pontos: ", resultado);

            }
            else if(resultado == 4.00 && resultado < 5.00)
            {
                Console.WriteLine("Cuidado! Você ficou de recuperação: ");
                Console.WriteLine("O valor da sua média é de {0:F2} pontos: ", resultado);
            }
            else if(resultado == 0.00 && resultado < 4.00)
            {
                Console.WriteLine("Sinto muito! Você foi reprovado, pois não alcançou a média.");
                Console.WriteLine("O valor da sua média é de {0:F2} pontos: ", resultado);

            }
            else
            {
                Console.WriteLine("O valor informado de alguma(as), ou de todas as notas, está incorreto! ");
            }

            


            Console.WriteLine("Digite uma quantidade de números inteiros: "); //ler 20 números inteiros e armazenar no vetor...
            int qntd = int.Parse(Console.ReadLine());

            int[] numeros3 = new int[qntd];
            int par = 0;
            int impar = 0;

            for(int i = 0; i < numeros3.Length; i++)
            {
                Console.WriteLine("Entre com os números do vetor: ");
                numeros3[i] = int.Parse(Console.ReadLine());

                if(numeros3[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }


            }

            Console.WriteLine("A quantidade de números pares são: {0} ",par);
            Console.WriteLine("A quantidade de números ímpares são: {0} ",impar);

        }
    }
}
