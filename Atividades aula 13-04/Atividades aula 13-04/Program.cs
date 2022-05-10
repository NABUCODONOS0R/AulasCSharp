using System;

namespace Atividades_aula_13_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;  //ler um ano e dizer se ele é bissexto
            Console.WriteLine("Digite um ano para saber se ele é bissexto: ");
            ano = int.Parse(Console.ReadLine());
            if (ano % 4 == 0)
            {
                Console.WriteLine("{0} é um ano bissexto", ano);
            }
            else
            {
                Console.WriteLine("{0} não é um ano bissexto", ano);
            }





            int numero = 0; //ler um número e imprimir par o ímpar
            Console.WriteLine("Digite um número para saber se ele é ímpar ou par: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("{0} é um número par ", numero);
            }
            else
            {
                Console.WriteLine("{0} é um número ímpar ", numero);
            }




            int numero1 = 0; //ler dois números e imprimir o maior deles
            Console.WriteLine("Digite um número:  ");
            numero1 = int.Parse(Console.ReadLine());

            int numero2 = 0;
            Console.WriteLine("Agora digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O maior número dentre as opções é:"+"  "+  Math.Max(numero1, numero2));

            



            int numero3, numero4, numero5; //ler três números e imprimimr o maior dentre eles
            Console.WriteLine("Digite três números inteiros: ");
            numero3 = int.Parse(Console.ReadLine());
            numero4 = int.Parse(Console.ReadLine());
            numero5 = int.Parse(Console.ReadLine());

            if (numero3 > numero4 && numero3 > numero5)
            {
                Console.WriteLine("{0} é o maior número dentre os escolhidos.", numero3);
            }
            else if (numero4 > numero3 && numero4 > numero5)
            {
                Console.WriteLine("{0} é o maior dentre os números escolhidos.", numero4);
            }
            else
            {
                Console.WriteLine("{0} é o maior dentre os números escolhidos.", numero5);
            }

            




            char sexo;  //receber o sexo de uma pessoa e imprimir o sexo digitado

            Console.WriteLine("Digite seu sexo (F ou M): ");
            sexo = char.Parse(Console.ReadLine());

            if (sexo == 'f' || sexo == 'F')
            {
                Console.WriteLine("O sexo digitado foi Feminino. ");
            }

            else if (sexo == 'm' || sexo == 'M')
            {
                Console.WriteLine("o sexo digitado foi Masculino. ");
            }

            else
            {
                Console.WriteLine("O sexo digitado está inválido. ");
            }



            


            double n1, n2, n3, n4; //ler quatro notas e imprimir a média
            

            Console.WriteLine("Digite o valor das suas quatros notas dos semestres: ");

            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());

            double media = ((n1 + n2 + n3 + n4)/ 4);

            Console.WriteLine("A sua média de notas é:   "+ media);







        }
    }
}
