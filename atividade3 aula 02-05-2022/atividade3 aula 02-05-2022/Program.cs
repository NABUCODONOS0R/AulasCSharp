using System;

namespace atividade3_aula_02_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Animal animal1, animal2, animal3;
            animal1 = new Animal();
            animal2 = new Animal();
            animal3 = new Animal();


            Console.WriteLine("Digite  o nome do animal: ");
            animal1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de patas que o animal possui: ");
            animal1.QntdPatas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a espécie do animal (Ex.: cachorro. gato, etc.) ");
            animal1.Especie = Console.ReadLine();



            Console.WriteLine("Digite  o nome do animal: ");
            animal2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de patas que o animal possui: ");
            animal2.QntdPatas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a espécie do animal (Ex.: cachorro. gato, etc.) ");
            animal2.Especie = Console.ReadLine();



            Console.WriteLine("Digite  o nome do animal: ");
            animal3.Nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de patas que o animal possui: ");
            animal3.QntdPatas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a espécie do animal (Ex.: cachorro. gato, etc.) ");
            animal3.Especie = Console.ReadLine();



            Console.WriteLine("Nomme do Animal: {0}  Espécie do Animal: {1}   Quantidade de Patas: {2} "
                ,animal1.Nome,animal1.Especie,animal1.QntdPatas );


            Console.WriteLine("Nomme do Animal: {0}  Espécie do Animal: {1}   Quantidade de Patas: {2} "
                , animal2.Nome, animal2.Especie, animal2.QntdPatas);


            Console.WriteLine("Nomme do Animal: {0}  Espécie do Animal: {1}   Quantidade de Patas: {2} "
                , animal3.Nome, animal3.Especie, animal3.QntdPatas);




        }



    }



}
