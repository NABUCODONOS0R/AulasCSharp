using System;
using System.IO;

namespace Atividade_01_Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arquivOrigem = @"c:\pasta\doc3.txt";
            string arquivoDestino = @"c:\pasta\subpasta\doc6.txt";

            try
            {
                string[] linhas = File.ReadAllLines(arquivOrigem);//lê todas as linhas
                using (StreamWriter sw = File.AppendText(arquivoDestino))
                {//^recebe o arquivo de destino onde iremos escrever
                    foreach (string linha in linhas)//pega tudo que leu nas linhas do arquivo
                    {//e imprime linha por linha contida no array
                        sw.WriteLine(linha.ToUpper());//escreve no arquivo em caixa alta
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }


        }
    }
}
