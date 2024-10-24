using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class EjercicioThreadTask
    {
        public static void MainFalso()
        {
            EjercicioThreadTask ejercicio = new EjercicioThreadTask();
            ejercicio.Ejecutar();
            Console.ReadLine(); // Mantener la consola abierta
        }
        public void Ejecutar()
        {
            Debug.WriteLine($"Ejecutar inicia en hilo {Thread.CurrentThread.ManagedThreadId}");

            // Opción 1: new Task(Action).Start();
            // No devuelve valor
            Task task = new Task(HacerAlgo);
            task.Start();
            Debug.WriteLine($"Ejecutar continua en hilo {Thread.CurrentThread.ManagedThreadId}");

            // Tarea que devuelve valor
            Task<string> taskThatReturnsValue = new Task<string>(HacerAlgoYDevolverValor);
            taskThatReturnsValue.Start();
            Debug.WriteLine($"Ejecutar continua en hilo {Thread.CurrentThread.ManagedThreadId} - Opción 1");

            // Se bloquea el hilo actual hasta que finalice la tarea
            taskThatReturnsValue.Wait();
            // Espera hasta obtener el resultado, tiene el mismo efecto que Wait
            Debug.WriteLine(taskThatReturnsValue.Result);

            // Opción 2: Task.Run();
            var task3 = Task.Run(() => HacerAlgoYDevolverValor2());
            // Se continua en el hilo original
            Debug.WriteLine($"Ejecutar continua en hilo {Thread.CurrentThread.ManagedThreadId} - Opción 2.");
            // Espera hasta obtener el resultado, tiene el mismo efecto que Wait
            Debug.WriteLine(task3.Result);

            Debug.WriteLine("Hilo Principal: Inicia nuevo hilo.");
            Thread t = new Thread(new ThreadStart(HacerAlgo));
            t.Start();
            for (int i = 0; i < 10; i++)
            {
                Debug.WriteLine($"Hilo Principal {i}: id {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(0);
            }

            Debug.WriteLine("Hilo Principal: Llama a Join(), espera que el hilo termine");
            t.Join();
            Debug.WriteLine("Hilo Principal: Hilo trabajador finalizó.");
        }

        private void HacerAlgo()
        {
            for (int i = 0; i < 10; i++)
            {
                Debug.WriteLine($"Hilo trabajador: {i}: id {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        private string HacerAlgoYDevolverValor()
        {
            // Simula un trabajo que devuelve un valor
            Thread.Sleep(1000); // Simular un trabajo
            return "Resultado de HacerAlgoYDevolverValor";
        }

        private string HacerAlgoYDevolverValor2()
        {
            // Simula otro trabajo que devuelve un valor
            Thread.Sleep(1000); // Simular un trabajo
            return "Resultado de HacerAlgoYDevolverValor2";
        }
    }    
}
