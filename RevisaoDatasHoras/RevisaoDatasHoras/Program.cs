using System;

namespace RevisaoDatasHoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AULA 17/05/2022 DE DATETIME E TIME SPAN

            
            Console.WriteLine("Date Time\n");


            DateTime d1 = DateTime.Now;//informa a data e a hora atual do sitema.
            DateTime d2 = new DateTime(1998, 02, 25);//armazena data especificada e hora zerada.
            DateTime d3 = new DateTime(1998, 02, 25, 06, 36, 39);//armazena data e hora especificada.
            DateTime d4 = DateTime.UtcNow;//informa a data e a hora no horário de greenwich
            DateTime d5 = DateTime.Today;//informa a data atual e a hora zerada.
            DateTime d6 = DateTime.Parse("05/01/2008 06:36:39 PM", System.Globalization.CultureInfo.InvariantCulture); //*** dar erro na minha data de nascimento. algo a ver com o calendário chinês
            DateTime d7 = DateTime.ParseExact("05/01/2008 06:36:39", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture); //***mesma observação anterior
            string d8 = d1.ToLongDateString();
            string d9 = d1.ToLongTimeString();
            string d10 = d1.ToShortDateString();

            Console.WriteLine(d1);//imprime a data e a hora atual do sitema.
            Console.WriteLine(d1.Ticks);//imprime a quantidade de ticks que a data informada possui.
            Console.WriteLine(d1.AddDays(2));//imprime o dia e a hora do sistema atual com dois dias a mais.
            Console.WriteLine(d1.DayOfWeek);//imprime o dia da semana da data informada.
            Console.WriteLine(d1.DayOfYear);//imprime o dia do ano da data informada (entre 1 e 365).
            Console.WriteLine(d1.ToLocalTime());//imprime a data e hora atual do sistema.
            Console.WriteLine(d1.ToLongDateString());//imprime por extenso a data informada.
            Console.WriteLine(d2);//imprime data especificada e hora zerada.
            Console.WriteLine(d3);//imprime data e hora especificada.
            Console.WriteLine(d4);//imprime a data e a hora no horário de greenwich
            Console.WriteLine(d5);//imprime a data atual e a hora zerada.
            Console.WriteLine(d6);//imprime a data e hora informada no formato 24h.**
            Console.WriteLine(d7);//imprime a data e hora informada no formato 12h.**
            Console.WriteLine(d8);//imprime a data atual do sistema por extenso.
            Console.WriteLine(d9);//imprime a hora atual do sistema.
            Console.WriteLine(d10);//imprime a data atual do sistema.


            Console.WriteLine("\nTime Span\n");


            TimeSpan time = new TimeSpan();//armazena o horário zerado.
            TimeSpan time2 = new TimeSpan(06, 36, 39);//armazena um horário informado.
            TimeSpan time3 = TimeSpan.FromDays(2);//armazena a quantidade de dias informado e o horário zerado.
            TimeSpan time4 = TimeSpan.FromHours(6.3);//armazena a quantidade de horas que equivale um double informado.
            TimeSpan time5 = TimeSpan.FromMinutes(6.3);//armazena a quantidade de minutos que equivale um double informado.
            TimeSpan time6 = TimeSpan.FromTicks(600000000000); //informa quanto tempo vale uma quantidade de ticks.
            Console.WriteLine(time);//imprime o horário zerado.
            Console.WriteLine(time2);//imprime um horário informado.
            Console.WriteLine(time3);//imprime a quantidade de dias informado e o horário zerado.
            Console.WriteLine(time4);//imprime a quantidade de horas que equivale um double informado.
            Console.WriteLine(time5);//imprime a quantidade de minutos que equivale um double informado.
            Console.WriteLine(time6);//imprime quanto tempo vale uma quantidade de ticks.

            



            //AULA 18/05/2022 DE DATETIME E TIME SPAN


             DateTime dataAtual = new DateTime(1998, 02, 25);
             DateTime dataFutura = new DateTime(2022, 02, 25);
             TimeSpan diferenca = dataFutura.Subtract(dataAtual); //armazena a iferença entre duas datas
             Console.WriteLine(diferenca);//imprime a quantidade, em int, da diferença de dias e a hora zerada.
             Console.WriteLine(diferenca.Days);//imprime a quantidade de dias.
             Console.WriteLine(diferenca.Hours);//imprime a diferença em horas.
             Console.WriteLine(diferenca.Minutes);//imprime a diferença em minutos.
             Console.WriteLine(diferenca.TotalDays);//imprime a diferença em dias.
             Console.WriteLine(diferenca.TotalHours);//converte a diferenca de dias para horas e imprime a diferença em horas.
             Console.WriteLine(diferenca.TotalMinutes);//converte a diferença de dias para minutos e imprime a diferença em minutos.
             double minutos = diferenca.TotalMinutes;
             Console.WriteLine((int)minutos);////converte a diferença de dias para minutos e imprime a diferença em minutos.

             Console.WriteLine("\n1===============================================");
            
             DateTime data = new DateTime(2022, 05, 18, 19, 20, 55, DateTimeKind.Local);//armazena, como horário local, a data e hora especificada.
             DateTime data1 = new DateTime(2022, 05, 18, 19, 20, 55, DateTimeKind.Utc);//armazena, como horário local, a data e hora especificada.
             DateTime data2 = new DateTime(2022, 05, 18, 19, 20, 55, DateTimeKind.Unspecified);//armazena, como horário local, a data e hora especificada.
             //ja instanciamos com o kind, por isso não altera nada
             Console.WriteLine("Local: " + data);//imprime, como horário local, a data e hora especificada.
             Console.WriteLine("utc: " + data1);//imprime, como horário local, a data e hora especificada.
             Console.WriteLine("unspecified: " + data2);//imprime, como horário local, a data e hora especificada.
             //especificando agora, pegando os dados da instancia e convertendo

             Console.WriteLine("\n2===============================================");
             
             Console.WriteLine("Data normal: " + data);//imprime a data e hora informada no horário local.
             Console.WriteLine("usando o kind: " + data.Kind);//imprime se é horário local ou o tipo do horário.
             Console.WriteLine("Hora local: " + data.ToLocalTime());//imprime a data e hora informada em horário local.
             Console.WriteLine("Horario universal: " + data.ToUniversalTime());//imprime a data e a hora em horário GMT +3.
             //especificando agora, pegando os dados da instancia e convertendo data1

             Console.WriteLine("\n3===============================================");
             
             Console.WriteLine("usando o kind: " + data1.Kind);//imprime a data e hora informada em horário local.
             Console.WriteLine("Hora local: " + data1.ToLocalTime());//imprime a data e hora informada em horário local.
             Console.WriteLine("Horario universal: " + data1.ToUniversalTime());//imprime a data e hora informada em horário local.
             //especificando agora, pegando os dados da instancia e convertendo data2

             Console.WriteLine("\n4===============================================");
             
             Console.WriteLine("Data normal: " + data2);//imprime a data especificada e o horário.
             Console.WriteLine("usando o kind: " + data2.Kind);//imprime o tipo de data.
             Console.WriteLine("Hora local: " + data2.ToLocalTime());//imprime a data especificada e o horário GMT - 3.
             Console.WriteLine("Horario universal: " + data2.ToUniversalTime());//imprime a data especificada e o horário GMT + 3.
             DateTime datas = DateTime.Parse("2022-05-18 19:30:45");//
             DateTime datas2 = DateTime.Parse("2022-05-18T19:30:45Z");
             Console.WriteLine(datas);//data guardada com horario utc
             Console.WriteLine(datas2);//data instanciada com o padrão iso retornando o horario GMT - 3.

             Console.WriteLine("\n5===============================================");
            
             Console.WriteLine("data 1: " + datas); // sem fuso
             Console.WriteLine("data 1 kind: " + datas.Kind); //retorna undefined
             Console.WriteLine("data 1 convertido para local: " + datas.ToLocalTime());//converte - 3
             Console.WriteLine("data 1 convertido para utc: " + datas.ToUniversalTime());//converte + 3

             Console.WriteLine("\n6===============================================");
             
             Console.WriteLine("data 2: " + datas2); //definido o horario ja convertido em GMT - 3.
             Console.WriteLine("data 2 kind: " + datas2.Kind); //retorna que é local
             Console.WriteLine("data 2 convertido para local: " +datas2.ToLocalTime()); //converte para  GMT - 3.
             Console.WriteLine("data 2 convertido para utc: " + datas2.ToUniversalTime()); //converte para GMT + 3.
             Console.WriteLine("Jeito certo para salvar no banco: ");
             Console.WriteLine(datas2.ToUniversalTime().ToString("yyyy - MM - ddTHH:mm: ssZ")); //guarda com o valor utc

             Console.WriteLine("\n7===============================================");
             
             DateTime data4 = DateTime.Now;//armazena a data e o horário atual.
             Console.WriteLine("Data atual: " + data4);//imprime a data e o horário atual.
             string convertida = data.ToUniversalTime().ToString("yyyy- MM - ddTHH:mm: ssZ");//converte para o modo ideal para banco de dados.
             Console.WriteLine("Convertida: " + convertida);//imprime a conversão.
             Console.WriteLine("Mostrando de novo: " + DateTime.Parse(convertida));//imprime convertida para GMT - 3.

             Console.WriteLine("\n8===============================================");
             
             DateTime dataAtual2 = new DateTime(2022, 05, 18);
             DateTime dataFutura2 = new DateTime(2022, 05, 31);
             TimeSpan diferenca2 = dataFutura2.Subtract(dataAtual2);//diferença de datas.
             Console.WriteLine(diferenca2.Days);//imprime, em int, a diferença em dias.
             Console.WriteLine(diferenca2.Hours);//imprime, em int, a diferença em horas
             Console.WriteLine(diferenca2.Minutes);//imprime a diferença em minutos.
             Console.WriteLine(diferenca2.TotalDays);//converte e imprime a diferença em dias.
             Console.WriteLine(diferenca2.TotalHours);//converte e imprime a diferença em horas.
             Console.WriteLine(diferenca2.TotalMinutes);//converte e imprime a diferença em minutos.
             double minutos2 = diferenca2.TotalMinutes;//converte a diferença em minutos.
             Console.WriteLine((int)minutos2);//imprime a diferença em minutos.

        }
    }
}
