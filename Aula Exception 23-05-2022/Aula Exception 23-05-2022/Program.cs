using System;
using Aula_Exception_23_05_2022.Entities; //importando as classes da pasta entities. EXEMPLO 02
using Aula_Exception_23_05_2022.Entities.Exceptions; //importando as classes da pasta exceptions. EXEMPLO 02

namespace Aula_Exception_23_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO 01
            //Try e catch
            
            try
            {
                Console.WriteLine("Digite um número inteiro: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um número inteiro: ");
                int n2 = int.Parse(Console.ReadLine());
                double resultado = n1 / n2;
                Console.WriteLine("O resultado é :" + resultado);

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("O Quociente da divisão não pode ser igual a zero. " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("O dado inserido deve ser um número inteiro. Você digitou uma letra. " + "\n" + e.Message);
            }
            

            //EXEMPLO 02
            try
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor unitário do produto: ");
                double valor = double.Parse(Console.ReadLine());

                Produto produto = new Produto(nome, quantidade, valor);
                produto.VerificarErro(nome); //Verifica se o nome possui mais de 3 caracteres.
                produto.VerificarErro(quantidade); //Verifica se a quantidade é maior que zero e diferente de um número negativo
                Console.WriteLine(produto);//Imprime o que está na classe produto, caso não tenha nenhum tipo de erro.


            }
            catch (ExcecaoProduto e)
            {
                Console.WriteLine("Erro: " +e.Message);//Caso tenha algum erro imprime a mensagem de erro que contém na classe produto.

            }

            

           
        }
    }
}
