using System;
using System.IO;

namespace Aula_01_Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FILE INFO PARA COPIAR UM DOCUMENTO DE TEXTO JÁ EXISTENTE NO PC E IMPRIMIR NA TELA.
            string arquivoOrigem = @"c:\temp\doc.txt";
            string arquivoDestino = @"c:\temp\novodoc.txt";
            try
            {
                FileInfo arquivoOrg = new FileInfo(arquivoOrigem); //Instanciação do FileInfo.
                arquivoOrg.CopyTo(arquivoDestino); //Copiar tudo do arquivo 01 para o arquivo 02.

                string[] arquivoLido = File.ReadAllLines(arquivoOrigem); //Utilizando o file para ler todas as linhas do arquivo de origem
                //e armazenar no array de strings arquivoLido.
                
                foreach(string leitura in arquivoLido) //Imprimir tudo que leu do arquivo de origem (a leitura dentro de arquivo lido.
                {
                    Console.WriteLine(leitura); //imprimir tudo o que o arquivo lido leu
                }
            }catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu! " + e.Message);
            }

            //====================================================================================================================================
            //====================================================================================================================================
            //====================================================================================================================================

            Console.WriteLine("\n\n\n");
            //UTILIZANDO O FILE STREAM PARA ACESSAR E MODIFICAR UM ARQUIVO (NESSE CASO LER UM DOCUMENTO DE TEXTO EXISTENTE).
            FileStream fileStream = null; //Declarando o FileStream inicializando-o como nulo
            StreamReader streamReader = null; //o mesmo. isso porque ao final precisamos finalizar esses comandos.
            try
            {
                fileStream = new FileStream(arquivoOrigem, FileMode.Open); //fileStream recebendo uma nova instância
                //primeiro é a pasta ou o arquivo que deseja acessar e depois o que desja fazer (no caso file.mode é pra abrir o arquivo.

                streamReader = new StreamReader(fileStream);
                while (!streamReader.EndOfStream)//enquanto não chegar ao fim da leitura, ele entra no loop
                {
                    string linha = streamReader.ReadLine();//lê o arquivo (cada linha) e armazena na variavel
                    Console.WriteLine(linha);//imprime cada linha do stream reader
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                if (fileStream != null) fileStream.Close();
            }


            //====================================================================================================================================
            //====================================================================================================================================
            //====================================================================================================================================
            

            /*
            //EXEMPLO DE CÓDIGO MAIS RESUMIDO DO ANTERIOR, MAS O ANTERIOR É MAIS EFICIENTE
            string arquivoOrigem = @"c:\temp\doc.txt";
            string arquivoDestino = @"c:\temp\novodoc.txt";
            try
            {
                using (FileStream fs = new FileStream(arquivoOrigem, FileMode.Open))
                {
                    using (StreamReader rs = new StreamReader(fs))
                    {
                        while (!rs.EndOfStream)
                        {
                            string linhas = rs.ReadLine();
                            Console.WriteLine(linhas);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Deu erro: ");
                Console.WriteLine(e.Message);
            }*/

            
            string arquivoOrigem3 = @"c:\temp\doc.txt";
            string arquivoDestino3 = @"c:\temp\doc1.txt";

            try
            {
                string[] linhas = File.ReadAllLines(arquivoOrigem3);// o array recebe um file que lê todas as linhas do arquivoOrigem
                using (StreamWriter sw = File.AppendText(arquivoDestino3))//utilizou o using para utilizar o streamwriter. o sw recebe um file que escreve no arquivo de destino
                {//^recebe o arquivo de destino onde iremos escrever
                    foreach (string linha in linhas)//dentro da string linha no array linhas pega o sw.writeLine e escreve a string linha em letra maiúscula. (pega tudo que leu nas linhas do arquivo).
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
