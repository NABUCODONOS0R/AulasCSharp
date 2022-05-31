using System;
using Atividade_Exception.Entities;
using Atividade_Exception.Entities.Exception;
namespace Atividade_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try //EXECUTA ESSE CÓDIGO E SE ACHAR ALGUMA EXCEÇÃO ELE EXECUTA O CATCH.
            {
                Usuario usuario = new Usuario();

                Console.WriteLine("Digite o nome completo: ");
                usuario.Nome = Console.ReadLine();
                Console.WriteLine("Digite o email:");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Digite a senha: ");
                usuario.Senha = Console.ReadLine();
                usuario.VerificarCaracteres(usuario.Senha);
                Console.WriteLine("Confirme a senha: ");
                usuario.ConfirmaSenha = Console.ReadLine();
                usuario.ConfirmacaoSenha(usuario.ConfirmaSenha);
                Console.WriteLine(usuario);

            }
            catch(ExcecaoUsuario erro)
            {
                Console.WriteLine("Erro: " + erro.Message) ;
            }
        }
    }
}
