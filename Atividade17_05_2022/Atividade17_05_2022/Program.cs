using System;

namespace Atividade17_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.UtcNow;
            Console.WriteLine(d1);


            Console.WriteLine("Digite sua data de nascimento: ");
            string d2 = Console.ReadLine();
            DateTime d3 = DateTime.Parse(d2);
            string d4 = d3.ToShortDateString();
            string d10 = d1.ToShortDateString();
            
           

            


             Console.WriteLine("Você nasceu em {0}, e tem {1} anos de idade",d4, d3.DayOfYear);
            

            
            
            


        }
    }
}
