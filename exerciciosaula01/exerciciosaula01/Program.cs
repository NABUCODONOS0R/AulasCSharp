using System;

namespace exerciciosaula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alô Mundo! "); //imprimir mensagem na tela

            int numero = 9; //imprimir um número na tela
            Console.WriteLine("O número inserido foi: " + numero);



            int n1 = 9; //imprimir a soma de dois números
            int n2 = 6;
            int soma = n1 + n2;
            Console.WriteLine("A soma dos dois números é: " + soma);


            double nota1 = 10, nota2 = 7, nota3 = 6, nota4 = 9, media; //imprimir a média de notas
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A média do aluno é: " + media);


            double area = 0, largura = 12.6, altura = 12.9; //imprimir o dobro da área do quadrado
            area = (largura * altura)*2;
            Console.WriteLine("O dobro da área do quadrado é: " + area);


            double salario = 0, valorhora = 5.60, horatrab = 220; //imprimir o valor do salário
            salario = (valorhora * horatrab);
            Console.WriteLine("O valor do seu salário no mês é: " + salario);


            double celsius = 0, fahrenheit = 36; //transformar fahrenheit em celsius
            celsius = 5 * ((fahrenheit - 32) / 9);
            Console.WriteLine("A temperatura em °C é: " + celsius);


            double fh = 0, cel = 36; //transformar celsius em fahrenheit
            fh = (cel * 9/5) + 32;
            Console.WriteLine(" A temperatura em °F é: " + fh);


            double pesoideal = 0, haltura = 1.70; //calcular opeso ideal
            pesoideal = (72.7 * haltura) - 58;
            Console.WriteLine("O peso ideal é: " + pesoideal);


            double pesoideal1 = 0, pesoideal2 = 0, h1 = 1.70; //calcular o peso ideal de homem e mulher
            pesoideal1 = (72.7 * h1) - 58;
            pesoideal2 = (62.1 * h1) - 44.7;
            Console.WriteLine("O peso ideal, caso for homem, é: " + pesoideal1 );
            Console.WriteLine("Caso for mulher, seu peso ideal é: " + pesoideal2);






            

        }
    }
}
