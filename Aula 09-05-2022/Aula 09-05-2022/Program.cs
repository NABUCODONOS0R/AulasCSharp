using System;
using System.Collections.Generic;

namespace Aula_09_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            //Adicionar nomes a lista
            nomes.Add("Marcos Mendes");
            nomes.Add("Mateus silva");
            nomes.Add("Rosa Sales");
            nomes.Add("Marcia Garcia");
            nomes.Add("Gustavo Pereira");
            nomes.Add("Menendez Solt");

            //Inserir nomes a lista
            nomes.Insert(6, "Ana Scott");
            nomes.Insert(0, "Ana Pereira");

            //Percorrer os dados da lista = imprimir na tela os nomes adicionados
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\n\n\n");


            //Saber o tamanho da lista ou quantidade de itens
            Console.WriteLine("Quantidade de itens na lista: " + nomes.Count);
            Console.WriteLine("\n\n\n");

            //Encontrar o primeiro elemento que atenda a um requisito obs.: => = receber ou tal que
            Console.WriteLine("Primeiro elemento com a letra inicial M: " + nomes.Find(x => x[0] == 'M'));

            //Encontrar o último elemento que atenda a um requisito
            Console.WriteLine("Ultimo elemento com a letra inicial M: " + nomes.FindLast(x => x[0] == 'M'));

            //Encontrar a posição do elemento que atenda a um requisito
            Console.WriteLine("Primeira posição do elemento com a letra inicial G: " + nomes.FindIndex(x => x[0] == 'G'));

            //Encontrar a posição do elemento que atenda a um requisito
            Console.WriteLine("Primeira posição do elemento com a letra inicial G: " + nomes.FindLast(x => x[0] == 'G'));
            Console.WriteLine("Primeira posição do elemento com a letra inicial r: " + nomes.FindLast(x => x[2] == 'r'));
            Console.WriteLine("\n\n\n");


            //Filtrar a lista
            List<string> nomes2 = nomes.FindAll(x => x[0] == 'M');

            Console.WriteLine("Lista 2: ");
            foreach (string obj in nomes2)
            {
                Console.WriteLine(obj);
            }


            //Remover elementos da lista
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Itens removidos: ");
            nomes.Remove("ana");
            nomes.RemoveAll(x => x[0] == 'G');
            nomes.RemoveAt(6);
            nomes.RemoveRange(2, 2);


            //Percorrer os dados da lista Foreach
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
