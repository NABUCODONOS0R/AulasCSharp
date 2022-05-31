using System;
using Atividade02_Exception.Entities;
using Atividade02_Exception.Entities.Exceptions;

namespace Atividade02_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Usuario usuario = new Usuario();

                Console.WriteLine("Digite seu nome completo: ");
                usuario.Nome = Console.ReadLine();
                Console.WriteLine("Digite sua data de nascimento:");
                usuario.DataNasc = DateTime.Parse(Console.ReadLine());
                usuario.VerificarDataNasc(usuario.DataNasc);
                Console.WriteLine("Digite seu endereço de email: ");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                usuario.Senha = Console.ReadLine();
                usuario.VerificarCaracteres(usuario.Senha);
                Console.WriteLine("Confirme sua senha: ");
                usuario.ConfirmaSenha = Console.ReadLine();
                usuario.ConfirmacaoSenha(usuario.ConfirmaSenha);
                Console.WriteLine(usuario);


            }catch(ExcecaoUsuario erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }
            
        }
    }
}
