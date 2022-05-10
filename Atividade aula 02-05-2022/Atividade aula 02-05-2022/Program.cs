using System;

namespace Atividade_aula_02_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Pessoa pessoa1, pessoa2, pessoa3;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();
            pessoa3 = new Pessoa();



            Console.WriteLine("Digite seu nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu peso: ");
            pessoa1.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            pessoa1.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());



            Console.WriteLine("Digite seu nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu peso: ");
            pessoa2.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            pessoa2.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite seu nome: ");
            pessoa3.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu peso: ");
            pessoa3.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            pessoa3.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua idade: ");
            pessoa3.Idade = int.Parse(Console.ReadLine());



            if (pessoa1.Idade > pessoa2.Idade && pessoa1.Idade > pessoa3.Idade)
            {
                Console.WriteLine("{0} é o(a) mais velho(a). ",pessoa1.Nome);
            }

            else if(pessoa2.Idade > pessoa1.Idade && pessoa2.Idade > pessoa3.Idade)
            {
                Console.WriteLine("{0} é o(a) mais velho(a). ",pessoa2.Nome);

            }
            else
            {
                Console.WriteLine("{0} é o(a) mais velho(a). ",pessoa3.Nome);
            }

            if(pessoa1.Peso > pessoa2.Peso && pessoa1.Peso > pessoa3.Peso)
            {
                Console.WriteLine("{0} é o(a) mais pesado(a). ",pessoa1.Nome);
            }
            else if(pessoa2.Peso > pessoa1.Peso && pessoa2.Peso > pessoa3.Peso)
            {
                Console.WriteLine("{0} é o(a) mais pesado(a). ",pessoa2.Nome);
            }
            else
            {
                Console.WriteLine("{0} é o(a) mais pesado(a). ");
            }


   
        }


    }


}
