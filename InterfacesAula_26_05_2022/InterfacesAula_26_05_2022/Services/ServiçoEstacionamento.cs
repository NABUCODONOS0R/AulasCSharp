using System;
using System.Collections.Generic;
using System.Text;
using InterfacesAula_26_05_2022.Entities;


namespace InterfacesAula_26_05_2022.Services
{
    internal class ServicoEstacionamento
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        //private ImpostoEstacionamento ie = new ImpostoEstacionamento();
        private ITaxas _itaxas;
        public ServicoEstacionamento(double precoHora, double precoDia, ITaxas itaxas)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _itaxas = itaxas;
        }

        public void processarPagamento(Estacionado estacionado)
        {
            TimeSpan duracao = estacionado.Saida.Subtract(estacionado.Entrada);

            double pagamentoBase;

            if (duracao.TotalHours <= 3)
            {
                pagamentoBase = PrecoHora * Math.Round(duracao.TotalHours);
            }
            else
            {
                pagamentoBase = PrecoDia * Math.Round(duracao.TotalDays);
            }

            double taxa = _itaxas.ImpostoEst(pagamentoBase);//indo na interface para calcular o imposto e retornar na classe principal.
            //ir na interface Itaxas pega o contrato que é o imposto e passa o pagamento base para fazer esse cálculo.
            //double taxa = ie.ImpostoEst(pagamentoBase);
            estacionado.Fatura = new Fatura(pagamentoBase, taxa);//na fatura mostra o pagamento base e a taxa gerada na inteface Itaxas.
        }
    }

}
