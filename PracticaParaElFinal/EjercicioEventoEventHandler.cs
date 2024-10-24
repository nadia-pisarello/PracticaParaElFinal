using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class EjercicioEventoEventHandler
    {
        // event + EventHandler
        public static void MainFalso()
        {
            Contador c = new Contador(5);
            c.LimiteAlcanzado += c_LimiteAlcanzado; //Suscripción al evento
            Console.WriteLine("presione a para incrementar el total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("Adicionando 1: " + c.Total);
                c.Add(1, EventArgs.Empty);
            }
            Console.ReadKey();

        }
        static void c_LimiteAlcanzado( object sender, EventArgs e)
        {
            Console.WriteLine("Se alcanzó el límite");
        }
        class Contador // Clase publicadora
        {
            public event EventHandler LimiteAlcanzado;
            private int limite;                    
            private int total;                  

            public int Total { get => total; set => total = value; }

            public Contador(int limiteSuperado)
            {
                limite = limiteSuperado;
            }
            public void Add(object sender, EventArgs e)
            {
                Total += (int) sender;
                if (Total >= limite)            
                    LimiteAlcanzado?.Invoke(this,e);  
                                               
            }
        }
    }
}
