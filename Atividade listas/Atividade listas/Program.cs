using System;
using System.Collections.Generic;

namespace Atividade_listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcao;

            List<Funcionario> func = new List<Funcionario>();

            do
            {
                Console.Write("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o valor do salário do funcionário: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("Digite a idade do funcionário: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Digite o e-mail do funcionário: ");
                string email = Console.ReadLine();

                Console.Write("Digite o departamento do funcionário: ");
                string departamento = Console.ReadLine();
                departamento.ToLower();

                func.Add(new Funcionario(nome, idade, email, salario, departamento));

                Console.Write("Deseja realizar o cadastro de mais um funcionário? \nDigite: s (sim) n (não) ");
                opcao = char.Parse(Console.ReadLine());


            } while (opcao == 's');

            Console.WriteLine("\n\n\n");

            foreach (Funcionario obj in func)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\n\n\n");

            Console.WriteLine("Quantidade de trabalhadores: " + func.Count);

            int contador = 0;
            if (func.Exists(x => x.Departamento == "rh"))
            {
                foreach (Funcionario obj in func)
                {
                    if (obj.Departamento == "rh")
                    {
                        contador++;
                    }

                }
                Console.WriteLine("A quantidade de pessoas trabalhando no RH é :" + contador);
            }

        }
    }
}
