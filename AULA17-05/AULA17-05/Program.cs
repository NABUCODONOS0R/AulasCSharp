using System;
using System.Globalization;

namespace AULA17_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date Time\n");

            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(1998, 02, 25);
            DateTime d3 = new DateTime(1998, 02, 25, 06, 36, 39);


            DateTime d4 = DateTime.UtcNow;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.Parse("05/01/2008 06:36:39 PM", CultureInfo.InvariantCulture); //*** dar erro na minha data de nascimento. algo a ver com o calendário chinês
            DateTime d7 = DateTime.ParseExact("05/01/2008 06:36:39", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture); //*** mesma observação anterior
            string d8 = d1.ToLongDateString();
            string d9 = d1.ToLongTimeString();
            string d10 = d1.ToShortDateString();

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d1.AddDays(2));
            Console.WriteLine(d1.DayOfWeek);
            Console.WriteLine(d1.DayOfYear);
            Console.WriteLine(d1.ToLocalTime());
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine("\nTime Span\n");

            TimeSpan time = new TimeSpan();
            TimeSpan time2 = new TimeSpan(06, 36, 39);
            TimeSpan time3 = TimeSpan.FromDays(2);
            TimeSpan time4 = TimeSpan.FromHours(6.3);
            TimeSpan time5 = TimeSpan.FromMinutes(6.3);
            TimeSpan time6 = TimeSpan.FromTicks(600000000000);


            Console.WriteLine(time);
            Console.WriteLine(time2);
            Console.WriteLine(time3);
            Console.WriteLine(time4);
            Console.WriteLine(time5);
            Console.WriteLine(time6);


        }
    }
}
