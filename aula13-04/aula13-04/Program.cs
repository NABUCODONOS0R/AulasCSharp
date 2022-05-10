using System;
using System.Globalization;


namespace aula13_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero = 0; //pedir um número e digitá-lo na tela
            Console.Write("Entre com um número inteiro: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Número digitado: " + numero);

            double numero1 = 0.0; //pedir um número e digitá-lo na tela
            Console.Write("Entre com um número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número digitado: " + numero1);

            char caractere; //pedir um caractere e escrevê-lo na tela
            Console.Write("Escreva algum caractere: ");
            caractere = char.Parse(Console.ReadLine());
            Console.WriteLine("O caractere escrito foi: " + caractere);
            

            Console.WriteLine(Math.Min(1, 2)); //imprime o menor número entre 2 escolhidos
            Console.WriteLine(Math.Max(1, 9)); //imprime o maior entre dois números escolhidos
            Console.WriteLine(Math.Sqrt(9)); //imprime a raiz quadrada de um número
            Console.WriteLine(Math.Pow(9, 2)); //imprime a potência de um número
            Console.WriteLine(Math.Round(25.2369369, 2)); //imprime somente duas casas decimais
            Console.WriteLine(Math.PI * 2); //cálculo utilizando u número pi
            
            

            int n1 = 3 + 4 * 2; 
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8.0;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            

            double a = 1.0, b = -3.0, c = -4.0; //cálculo do segundo grau
            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine("O valor de delta é:  " + delta);
            Console.WriteLine("O valor de x1 é:  " + x1);
            Console.WriteLine("O valor de x2 é:  " + x2);

            double numero6 = 36.963369;
            Console.WriteLine(numero6.ToString("F3", CultureInfo.InvariantCulture));
            

            string x = "Bom dia! ";
            string y = "Boa Tarde! ";
            string z = "Boa Noite! ";
            int hora = 0;

            Console.WriteLine("Digite a hora atual: "); //Estrutura condicional composta
            hora = int.Parse(Console.ReadLine());

            if (hora >= 5 && hora <=12)
            {
                Console.WriteLine(x);
            }
            else if (hora > 12 && hora <=18)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(z);
            }




            



                 








        }
    }
}
