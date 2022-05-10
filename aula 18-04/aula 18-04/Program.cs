using System;

namespace aula_18_04
{
    class Program
    {
        static void Main(string[] args)
        {



            
           /* int x = 18; //variável Global

            if(x > 10)
            {
                int y = 20; //variável Local
            }

            */




            for (int i = 0; i <= 10; i++) //estrutura for - restrita a números.
                Console.WriteLine("Minha variável i está valendo:  " + i);
            





            int contador = 0;   //estrutura while - strings, char dentre outros.

            while (contador <= 10)

            {


                Console.WriteLine("Minha variável está valendo: " + contador);
                contador++;



            }
          
          



            char sexo = 'f';  //estrutura while.

            while(sexo == 'f')
            {
                Console.WriteLine("A variável sexo é: " + sexo);

                Console.WriteLine("Entre com o sexo: ");
                sexo = char.Parse(Console.ReadLine());

            }

            



            int exemplo = 0;

            do
            {
                Console.WriteLine(" Variável exemplo valendo: " + exemplo);
                exemplo++;
            } while (exemplo <= 10);


            



            string nome = "Marcos Mendes";
            Console.WriteLine(nome.Length);


            string senha = "123456";
            if(senha.Length < 6)
            {
                Console.WriteLine("A senha deve conter pelo menos 6 caracteres.");

            }
            else
            {
                Console.WriteLine("Senha atualizada.");
            }





        }
    }
}
