using System;
using System.Diagnostics;//EXEMPLO 01
using System.Threading;//EXEMPLO 01 AO 03
using System.Threading.Tasks;//EXEMPLO 04

namespace ThreadsTaskInterface_26_05__22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //EXEMPLO 01
            Thread linha = new Thread(ExecucaoSegundoPlano);//dentro da thread é passado o comando a ser excutado.
            linha.Start();//iniciando a thread.
            Thread.Sleep(1000);//dê um tempo de 1 segundo(1000 milisegundo) antes de executar o código abaixo.
            Console.WriteLine("Thread principal sendo executada ({0}) ... ", Thread.CurrentThread.ManagedThreadId);
            




            
            //EXEMPLO 02
            Thread thread2 = new Thread(new ThreadStart(T2));//instanciando a thread e criando uma nova instância
            //para startar a thread2.
            thread2.Start();

            Thread.Sleep(3000);//dar um tempo de 3 segundos para depois executar o código abaixo.
            Console.WriteLine("Mais 3 segundos de pausa. ");//executa esse comando antes do comando acima que contém o método
            




            
            //EXEMPLO 03
            int somar = 0;
            bool tempoDescanso = false;

            Thread thread3 = new Thread(new ThreadStart(() => //instanciou a thread e numa thread passando uma função anônima(=>) a ela.
            {
               while (!tempoDescanso)//enquanto o tempo de descanso não for positivo.
               {
                   somar++;//soma +1.
                   //Console.WriteLine(somar);
               }
            })); //toda a execução thread acima será executada em segundo plano.
            thread3.Start();
            Thread.Sleep(6000);
            tempoDescanso = true;

            Console.WriteLine("A soma no tempo de descanso foi {0}. ", somar);
            



            
            //EXEMPLO 04 TASKS
            Task tarefa1 = Task.Run(() => Console.WriteLine(Contar()));//() => é uma expressão lâmbida, que é uma fução anônima.
            tarefa1.Wait();//executa a tarefa espera um pouco e executa novamente enquanto o método contar estiver sendo satisfeito.
            



        }


        //FUNÇÕES
        
        //EXEMPLO 01
        static void ExecucaoSegundoPlano()
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            Console.WriteLine("Thread: {0}: {1}, Prioridade {2} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);
            //na linha tal pesquisa o id da thread depois o estado dela e depois a prioridade dela.
            do
            {
                Console.WriteLine(@"2) Linha {0}: decorreram {1:N2} sesgundos. ", Thread.CurrentThread.ManagedThreadId, stopWatch.ElapsedMilliseconds / 1000.00);
                //na linha tal pega o id e gerencia o id e imprime quanto tempo decorreu(em segundos) a função denominada stopWatch
                //divida o tempo por 1000 para ser impresso em segundos em vez de milisegundos
                Thread.Sleep(500);//dê um tempo de meio segundo.

            } while (stopWatch.ElapsedMilliseconds <= 5000);
        }
        

        
        //EXEMPLO 02
        static void T2()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Pausa de 5 segundos, continua ? ");
        }
        

        //EXEMPLO 04
        static int Contar()
        {
            int i;
            for(i = 0; i < 10; i++)
            {
                Thread.Sleep(3000);
                Console.WriteLine("Pausa de 3 segundos antes de imprimir i. ");
                Console.WriteLine(i);
                Console.WriteLine();
            }
            return i;

        }


    }
}
