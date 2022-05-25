using System;
using System.Collections.Generic;
using System.IO;
namespace Aula_Assincrona_20_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //procedimento 01
            //ler e listar os nomes dos diretórios de nível superior
            
            IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");
            

            foreach (var dir in listOfDirectories)
            {
                Console.WriteLine(dir);
            }

            // Outputs:
            // stores/201
            // stores/202


            //procedimento 02
            // listar os nomes de todos os arquivos em um diretório, você pode usar a função
            IEnumerable<string> files = Directory.EnumerateFiles("stores");

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            // Outputs:
            // stores/totals.txt
            // stores/sales.json


            //procedimento 03
            //Ambas as funções Directory.EnumerateDirectories e Directory.EnumerateFiles têm uma sobrecarga
            //que aceita um parâmetro para especificar um padrão de pesquisa a que os arquivos e diretórios
            //devem corresponder.
            //Elas também têm outra sobrecarga que aceita um parâmetro para indicar se é preciso percorrer
            //recursivamente uma pasta especificada e todas as suas subpastas.

                        // Find all *.txt files in the stores folder and its subfolders
                        IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

            foreach (var file in allFilesInAllFolders)
            {
                Console.WriteLine(file);
            }

            // Outputs:
            // stores/totals.txt
            // stores/201/inventory.txt
        }

    }
}
