using System;
using System.Collections.Generic;
using System.Text;
using Atividade_Exception.Entities.Exception;

namespace Atividade_Exception.Entities
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, string email, string senha, string confirmacaoSenha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            ConfirmaSenha = confirmacaoSenha;
        }

        public void VerificarCaracteres(string senha) //método que lança uma exceção.
        {
          if(senha.Length < 8)//caso a senha contenha menos que 8 caracteres, a exceção seguinte é lançada.
          {
            throw new ExcecaoUsuario("A senha não pode conter menos que 8 caracteres!");

          }
            
        }

        public void ConfirmacaoSenha(string confirmacaoSenha)
        {
          if(confirmacaoSenha != Senha)
            {
              throw new ExcecaoUsuario("A senha não confere com a anterior.");
            }
        }

        public override string ToString()
        {
            return Nome + "\nEmail: " + Email + "\nOs dados foram cadastrados. ";
        }


    }


}
