using System;

namespace atividade_18_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char turno; //imprimir bom dia, boa tarde ou boa noite.
            Console.WriteLine("Digite por favor qual turno você estuda: ");
            Console.WriteLine("Digite M para matutino, V para vespertino e N para noturno: ");
            turno = char.Parse(Console.ReadLine());


            if(turno == 'M')
            {
                Console.WriteLine("Bom dia! ");
            }
            else if (turno == 'V')
            {
                Console.WriteLine("Boa tarde! ");
            }
            else if(turno == 'N')
            {
                Console.WriteLine("Boa noite! ");
            }
            else
            {
                Console.WriteLine("O turno que você digitou está incorreto");
            }

            


            //receber o salário e imprimir o reajuste
            Console.WriteLine("Digite o valor do seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario == 0 && salario <= 280.00)
            {
                double salario1 = (salario) * 0.2 + salario;
                Console.WriteLine("Seu salário antes do reajuste era de R$ {0} e com o percentual de 20% seu salário atual é de R$ {1}.",salario,salario1);
            }
            else if (salario > 280.00 && salario <= 700.00)
            {
                double salario2 = (salario) * 0.15 + salario;
                Console.WriteLine("Seu salário antes do reajuste era de R$ {0} e com o percentual de 15% seu salário atual é de R$ {1}. ",salario,salario2);

            }
            else if (salario > 700.0 && salario <= 1500.00)
            {
                double salario3 = (salario) * 0.10 + salario;
                Console.WriteLine("Seu salário antes do reajuste era de R$ {0} e com o percentual de 10% seu salário atual é de R$ {1}. ",salario,salario3);

            }
            else
            {
                double salario4 = (salario) * 0.05 + salario;
                    Console.WriteLine("Seu salário antes do reajuste era de R$ {0} e com o ajuste de 5% seu salário atual é de R$ {1}. ",salario,salario4);
            }

            

            //pedir um número e retornar o dia da semana
            Console.WriteLine("Digite um número de 1 a 7");
            int numero = int.Parse(Console.ReadLine());

            if(numero == 1)
            {
                Console.WriteLine("Domingo");
            }
            else if(numero == 2)
            {
                Console.WriteLine("Segunda");
            }
            else if(numero == 3)
            {
                Console.WriteLine("Terça");
            }
            else if(numero == 4)
            {
                Console.WriteLine("Quarta");
            }
            else if(numero == 5)
            {
                Console.WriteLine("Quinta");
            }
            else if(numero == 6)
            {
                Console.WriteLine("Sexta");
            }
            else if(numero == 7)
            {
                Console.WriteLine("Sábado");
            }
            else
            {
                Console.WriteLine("O valor digitado não é válido.");
            }

            



            //problema da gasolina

            double precoAl = 5.12;
            double precoGa = 7.69;
           
            


            Console.WriteLine("Digite o combustível abastecido:  ");
            Console.WriteLine("A - Álcool      G - Gasolina:  ");
            char combustivel = char.Parse(Console.ReadLine());

            if(combustivel == 'A')
            {
                
                Console.WriteLine("Digite quantos litros de Álcool foram abastecidos:  ");
                double litros = double.Parse(Console.ReadLine());
                double total = litros * precoAl;
                double desconto = total - (total * 0.03);
                double desconto1 = total - (total * 0.05);


                if(litros >= 0.00 && litros <= 20.00)
                {
                    Console.WriteLine("O valor a ser pago é R$ {0:F2} ", desconto);
                }
                else if(litros > 20.00)
                {
                    Console.WriteLine("O valor a ser pago é R$ {0:F2} ", desconto1);
                }
                else
                {
                    Console.WriteLine("Informação incorreta!");
                }


            }
            else if(combustivel == 'G')
            {

                Console.WriteLine("Digite quantos litros de gasolina foram abastecidos:   ");
                double litros = double.Parse(Console.ReadLine());
                double total2 = litros * precoGa;
                double desconto3 = total2 - (total2 * 0.04);
                double desconto4 = total2 - (total2 * 0.06);


                if (litros >= 0 && litros <= 20.00)
                {
                    Console.WriteLine("O valor a ser pago é R$ {0:F2} ", desconto3);

                }
                else if(litros > 20.00)
                {
                    Console.WriteLine("O valor a ser pago é R$ {0:F2} ", desconto4);
                }
                else
                {
                    Console.WriteLine("Informação incorreta!");
                }


            }
            else
            {
                Console.WriteLine("Informação incorreta!");
            }





        }



    }


}
