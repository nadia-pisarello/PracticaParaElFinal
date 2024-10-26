using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class Thread00
    {    
        public static void MainFalso()
        {
            ContadorConcurrente contador = new ContadorConcurrente();
            ContadorConcurrente contador2= new ContadorConcurrente();
            Thread threadI = new Thread(new ThreadStart(contador.Incrementar));
            Thread threadD = new Thread(new ThreadStart(contador.Decrementar));
            // constructor Thread no admite directamente llamadas a métodos con parámetros.
            //Thread threadD = new Thread(new ThreadStart(contador2.Decrementar(24)));
            // Utilizar una expresión lambda o delegados para llamar al método con un parámetro
            //Thread threadD = new Thread(() => contador2.Decrementar(24));
            threadI.Start();
            threadD.Start();
            threadI.Join();
            threadD.Join();
            Console.WriteLine("Valor final contador 1: " + contador.Contador);
        }

        private class ContadorConcurrente
        {
            int contador;
            private readonly object bloqueo = new object();
            public int Contador { get => contador; set => contador = value; }
            public void Incrementar()
            {
                for(int i = 0; i < 10; i++)
                {
                    lock (bloqueo) 
                    {
                        Contador += 10;
                        Console.WriteLine("Contador 1: " + Contador);
                        Thread.Sleep(2000);
                    }
                }                    
            }

            public void Decrementar()
            {
                for(int i = 0; i < 10; i++)
                {
                    lock (bloqueo)
                    {
                        Contador -= 8;
                        Console.WriteLine("Contador 2: " + Contador);
                        Thread.Sleep(100);
                    }                    
                }
            }
        }
      
    }
}
