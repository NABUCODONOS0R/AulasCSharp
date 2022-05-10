//using System //System.Console substitui using System

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello Marcos Mendes"); //substitui using System
            //sbyte = System.Sbyte -128 <= x <= 127
            //short = System.Int16 -32768 <= x <= 32767
            //int = System.Int32 -2³¹ <= x <= 2³¹ -1
            //long = System.Int64 -2^64 <= x <= 2^64 -1
            //byte = System.Byte 0 <= x <= 255
            //ushort = System.Uint16 0 <= x <= 65535
            //uint = System.Uint32 0 <= x 2³² -1
            //ulong = System.Uint64 0 <= x <= 2^64 -1
            //float = System.Single x= muito grande e muito pequeno
            //double = System.Double x= muito grande e muito pequeno
            //decimal = System.Decimal x= muito grande e muito pequeno
            //char = System.Char x= CARACTERE
            //bool = System.Boolean x= verdadeiro ou falso
            //string nomeCompleto = "Marcos Mendes";
            //System.Console.WriteLine(nomeCompleto);

            //nomeCompleto = "Jéssica Pearson";
            //System.Console.WriteLine(nomeCompleto);

            //char sexo = 'F';
            //int idade = 24;
            //double preco = 36.90;

            //string nome = "Marcos Mendes";
            //int idade = 24;
            //double investimento = 1375.369;

            //System.Console.WriteLine("{0} tem {1} anos e tem R$ {2:f2} reais investidos na bolsa de valores",nome,idade,investimento);

            string nome = "Marcos Mendes";
            int idade = 24;
            double investimento = 1375.369;

            System.Console.WriteLine($"{nome} tem {idade} anos e tem R$ {investimento:f2} investidos na bolsa de valores ");


        }
    }
}
