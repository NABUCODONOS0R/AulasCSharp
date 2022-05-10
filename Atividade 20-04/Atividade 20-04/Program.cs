using System;

namespace Atividade_20_04
{
    internal class Program
    {
        static void Main(string[] args)  //Progrma que necessita de um argumento P: para posistivo N: para zero ou negativo
        {
            int numero = 0;
            Console.WriteLine("Digite um número: ");
            numero =int.Parse(Console.ReadLine());
            Mensagem(numero);
            


        }

        static void Mensagem(int numero)
        {
            if(numero <= 0)
            {
                Console.WriteLine("N");

            }
            else if(numero > 0)
            {
                Console.WriteLine("P");
            }
            else
            {
                Console.WriteLine("Valor Incorreto!s");
            }
        }
    }
}
