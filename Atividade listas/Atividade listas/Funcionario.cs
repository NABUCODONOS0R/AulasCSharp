using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_listas
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }

        public Funcionario(string nome, int idade, string email, double salario, string departamento)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
            Salario = salario;
            Departamento = departamento;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nIdade: " + Idade + "\nEmail: " + Email + "\nSalário: R$ " + Salario.ToString("F2") + "\nDepartamento: " + Departamento;
        }



    }
}
