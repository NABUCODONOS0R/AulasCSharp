using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Herança
{
    internal class PessoaFisica : Pessoa
    {
        public ulong Rg { get; set; }
        public ulong Cpf { get; set; }
        public DateTime DataNasc { get; set; }

        public PessoaFisica()
        {

        }



        public PessoaFisica(string nome, string endereco, ulong rg, ulong cpf, DateTime dataNasc) : base(nome, endereco)
        {
            Rg = rg;
            Cpf = cpf;
            DataNasc = dataNasc;
        }



    }
}
