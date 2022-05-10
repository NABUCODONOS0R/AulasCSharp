using System;

namespace Atividade_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Marcos";
            var numero = 9;
            var real = 9.369;
            var bolean = true;

            Console.WriteLine(nome + numero + real + bolean);
            Console.WriteLine(nome.GetType());
            Console.WriteLine(numero.GetType());
            Console.WriteLine(real.GetType());
            Console.WriteLine(bolean.GetType());
                

            
        }
    }
}
