using System;
using InterfacesAula_26_05_2022.Entities;
using InterfacesAula_26_05_2022.Services;
using System.Globalization;

namespace InterfacesAula_26_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados solicitados do veiculo: ");

            Console.Write("Modelo:");
            string modelo = Console.ReadLine();

            Console.Write("Marca:");
            string marca = Console.ReadLine();

            Console.Write("Placa:");
            string placa = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite a data e a hora de entrada no formato abaixo: \n(dd/MM/yyyy HH:mm)");
            DateTime entrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Digite a data e a hora de saída no formato abaixo: \n(dd/MM/yyyy HH:mm)");
            DateTime saida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Digite o preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine());

            Estacionado est = new Estacionado(entrada, saida, new Carro(modelo, marca, placa));//o carro estacionado denominado est
            //recebeu uma nova instâncias de estrada e saída e uma nova instância para cllasse carro passando o modelo
            //a marca e a placa.

            ServicoEstacionamento servico = new ServicoEstacionamento(precoHora, precoDia, new ImpostoEstacionamento());

            servico.processarPagamento(est);

            Console.WriteLine("fatura gerada para o tempo estacionado: ");
            Console.WriteLine(est.Fatura);
        }
    }
}
