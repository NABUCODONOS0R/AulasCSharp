using System;

namespace Atividade_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite um texo: "); //Ler um texto e imprimir em maiúscula e minúscula.
            string texto = Console.ReadLine();
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper()); 

            Console.WriteLine("Digite uma frase:"); //Solicitar uma frase e uma palavra da frase para substituir por outra
            string frase = Console.ReadLine();
            Console.WriteLine("Agora escolha uma palavra da frase que você escreveu: ");
            string palavra = Console.ReadLine();
            Console.WriteLine("Agora escolha a palavra que você quer colocar no lugar dela: ");
            string troca = Console.ReadLine();
            Console.WriteLine(frase.Replace(palavra,troca)); 


            Console.WriteLine("Digite uma frase: "); //solicitar uma frase e uma palavra e mostrar o índice onde a palavra se encontra
            string frase2 = Console.ReadLine();
            Console.WriteLine("Escolha uma palavra da sua frase: ");
            string palavra1 = Console.ReadLine();
            Console.WriteLine("A palavra escolhida se encontra no índice {0}", frase2.IndexOf(palavra1)); 


            Console.WriteLine("Digite uma frase: "); //a apartir de uma string imprimir n° de caracteres, maiúscula e n° de vogais
            string frase3 = Console.ReadLine();
            Console.WriteLine("Sua frase possui {0} caracteres, incluíndo espaços em branco. ", frase3.Length);
            Console.WriteLine(frase3.ToUpper()); 


            Console.WriteLine("Digite uma frase: "); //imprimir separadamente as´palavras de uma frase
            string frase4 = Console.ReadLine();
            string[] frase5 = frase4.Split(' ');

            for (int i = 0; i < frase5.Length; i++)
            {
                Console.WriteLine(frase5[i]);
            }
            


        }
    }
}
