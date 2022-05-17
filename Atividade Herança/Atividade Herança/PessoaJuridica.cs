using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Herança
{
    internal class PessoaJuridica : Pessoa
    {
        public ulong InscricaoEstadual { get; set; }
        public ulong Cnpj { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, string endereco, ulong inscricaoEstadual, ulong cnpj) : base(nome, endereco)
        {
            InscricaoEstadual = inscricaoEstadual;
            Cnpj = cnpj;
        }






    }
}
