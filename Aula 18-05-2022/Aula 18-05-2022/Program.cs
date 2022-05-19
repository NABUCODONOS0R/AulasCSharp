using System;

namespace Aula_18_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual = new DateTime(1998, 02, 25);
            DateTime dataFutura = new DateTime(2022, 02, 25);

            TimeSpan diferenca = dataFutura.Subtract(dataAtual); //Diferença entre horas
            Console.WriteLine(diferenca);
            Console.WriteLine(diferenca.Days);
            Console.WriteLine(diferenca.Hours);
            Console.WriteLine(diferenca.Minutes);
            Console.WriteLine(diferenca.TotalDays);
            Console.WriteLine(diferenca.TotalHours);
            Console.WriteLine(diferenca.TotalMinutes);

            double minutos = diferenca.TotalMinutes;
            Console.WriteLine("\n" + (int)minutos);
            Console.WriteLine("\n===============================================");
            Console.WriteLine("\n\n\n");


            TimeSpan tempo1 = new TimeSpan(10, 55, 49); //Operações com horas(Time Span)
            TimeSpan tempo2 = new TimeSpan(2, 10, 49);
            Console.Write("Tempo 1 está valendo: " + tempo1);
            Console.Write("\nTempo 2 está valendo: " + tempo2);
            Console.Write("\nSomar o tempo 2 com o tempo1: " + tempo1.Add(tempo2));
            Console.Write("\nDiferença entre o tempo 2 e o tempo 1: " + tempo1.Subtract(tempo2));
            Console.Write("\nMultiplicar o tempo 1 por 2: " + tempo1.Multiply(2));
            Console.Write("\nDividir o tempo 1 por 2: " + tempo1.Divide(2));

            Console.WriteLine("\n===============================================");
            Console.WriteLine("\n\n\n");

            DateTime data = new DateTime(2022 , 05 , 18, 19, 20 , 55, DateTimeKind.Local);
            DateTime data1 = new DateTime(2022, 05, 18, 19, 20, 55, DateTimeKind.Utc);
            DateTime data2 = new DateTime(2022, 05, 18, 19, 20, 55, DateTimeKind.Unspecified);
            //ja instanciamos com o kind, por isso não altera nada
            Console.WriteLine("Local: "  + data);
            Console.WriteLine("utc: " + data1);
            Console.WriteLine("unspecified: " + data2);
            //especificando agora, pegando os dados da instancia e convertendo
            Console.WriteLine("\n===============================================");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Data normal: " + data);
            Console.WriteLine("usando o kind: " + data.Kind);
            Console.WriteLine("Hora local: " + data.ToLocalTime());
            Console.WriteLine("Horario universal: " + data.ToUniversalTime());
            //especificando agora, pegando os dados da instancia e convertendo data1
            Console.WriteLine("\n===============================================");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Data normal: " + data1);
            Console.WriteLine("usando o kind: " + data1.Kind);
            Console.WriteLine("Hora local: " + data1.ToLocalTime());
            Console.WriteLine("Horario universal: " + data1.ToUniversalTime());
            //especificando agora, pegando os dados da instancia e convertendo data2
            Console.WriteLine("\n===============================================");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Data normal: " + data2);
            Console.WriteLine("usando o kind: " + data2.Kind);
            Console.WriteLine("Hora local: " + data2.ToLocalTime());
            Console.WriteLine("Horario universal: " + data2.ToUniversalTime());

            DateTime datas = DateTime.Parse("2022-05-18 19:30:45");
            DateTime datas2 = DateTime.Parse("2022-05-18T19:30:45Z");
            Console.WriteLine(datas);//data guardada com horario utc
            Console.WriteLine(datas2);//data instanciada com o padrão iso retornando o horario local
            Console.WriteLine("\n===============================================");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("data 1: " + datas); // sem fuso
            Console.WriteLine("data 1 kind: " + datas.Kind); //retorna undefined
            Console.WriteLine("data 1 convertido para local: " + datas.ToLocalTime());//converte - 3
            Console.WriteLine("data 1 convertido para utc: " + datas.ToUniversalTime());//converte + 3
            Console.WriteLine("\n===============================================");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("data 2: " + datas2); //definido o horario ja convertido
            Console.WriteLine("data 2 kind: " + datas2.Kind); //retorna que é local
            Console.WriteLine("data 2 convertido para local: " + datas2.ToLocalTime()); //converte para local
            Console.WriteLine("data 2 convertido para utc: " + datas2.ToUniversalTime()); //converte para o utc
            Console.WriteLine("Jeito certo para salvar no banco: ");
            Console.WriteLine(datas2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); //guarda com o valor utc


            Console.WriteLine("\n===============================================");
            Console.WriteLine("\n\n\n");
            DateTime data4 = DateTime.Now;
            Console.WriteLine("Data atual: " + data4);
            string convertida = data.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            Console.WriteLine("Convertida: " + convertida);
            Console.WriteLine("Mostrando de novo: " + DateTime.Parse(convertida));

            Console.WriteLine("\n===============================================");
            Console.WriteLine("\n\n\n");
            DateTime dataAtual2 = new DateTime(2022 , 05 , 18);
            DateTime dataFutura2 = new DateTime(2022, 05 , 31);
            TimeSpan diferenca2 = dataFutura2.Subtract(dataAtual2);
            Console.WriteLine(diferenca2.Days);
            Console.WriteLine(diferenca2.Hours);
            Console.WriteLine(diferenca2.Minutes);
            Console.WriteLine(diferenca2.TotalDays);
            Console.WriteLine(diferenca2.TotalHours);
            Console.WriteLine(diferenca2.TotalMinutes);
            double minutos2 = diferenca2.TotalMinutes;
            Console.WriteLine("\n\n" + (int)minutos2);




        }
    }
}
