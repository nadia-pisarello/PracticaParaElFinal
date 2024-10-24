using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    //event + EventHandler<TEventtArgs>
    internal class EjercicioEventoEventHandlerEventArgs // clase suscriptora
    {
        public static void MainFalso()
        {
            Contador c = new Contador(5);
            c.LimiteAlcanzado += c_LimiteAlcanzado; //suscripción al evento
            Console.WriteLine("presione '+' para incrementar el total");
            while (Console.ReadKey(true).KeyChar == '+')
            {
                Console.WriteLine("Adicionando 1: " + c.Total);
                c.Add(1);
            }
        }

        static void c_LimiteAlcanzado(object sender, LimiteAlcanzadoEventArgs e) // Manejador del evento
        {
            Console.WriteLine("Se ha alcanzado el límite");
        }
        class Contador // Clase publicadora del evento
        {
            public event EventHandler<LimiteAlcanzadoEventArgs> LimiteAlcanzado; // Declaración del evento
            private int limite, total;

            public int Total { get => total; set => total = value; }

            public Contador(int limiteSuperado)
            {
                limite = limiteSuperado;
            }
            public void Add(int x)
            {
                Total += x;
                if (Total >= limite)
                {
                    LimiteAlcanzadoEventArgs args = new LimiteAlcanzadoEventArgs();
                    args.Limite = limite;
                    args.TiempoLimite = DateTime.Now;
                    EnElLimite(args);
                }
            }

            public virtual void EnElLimite(LimiteAlcanzadoEventArgs e)
            {
                LimiteAlcanzado?.Invoke(this, e); // Disparar el evento
            }
        }

        public class LimiteAlcanzadoEventArgs : EventArgs
        {
            public int Limite { get; set; }
            public DateTime TiempoLimite { get; set; }
        }
    }
}
