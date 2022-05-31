using System;
using System.Collections.Generic;
using System.Text;
using Atividade02_Exception.Entities.Exceptions;

namespace Atividade02_Exception.Entities
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, DateTime dataNasc, string email, string senha, string confirmaSenha)
        {
            Nome = nome;
            DataNasc = dataNasc;
            Email = email;
            Senha = senha;
            ConfirmaSenha = confirmaSenha;
        }

        public void VerificarDataNasc(DateTime dataNasc)
        {
            if (dataNasc >=  DateTime.Now)
            {
                throw new ExcecaoUsuario("Por favor, digite uma data de nascimento válida.");

            }
        }

        public void VerificarCaracteres(string senha) //método que lança uma exceção.
        {
          if(senha.Length< 8)//caso a senha contenha menos que 8 caracteres, a exceção seguinte é lançada.
          {
            throw new ExcecaoUsuario("A senha não pode conter menos que 8 caracteres!");
          }
        }

        public void ConfirmacaoSenha(string confirmacaoSenha)
        {
          if (confirmacaoSenha != Senha)
          {
            throw new ExcecaoUsuario("A senha não confere com a anterior.");
          }
        }

        public int CalculoIdade()
        {
          if(DataNasc.Month < DateTime.Now.Month)
          {
                return DateTime.Now.Year - DataNasc.Year;
          }
          else
          {
                return DateTime.Now.Year - DataNasc.Year - 1;

          }
          
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nIdade: " +  CalculoIdade() + " anos" + "\nEmail: " + Email + "\nDados cadastrados com sucesso. ";
        }

    }
}
