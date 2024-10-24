using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PracticaParaElFinal
{
    internal class EjercicioEventoTimer
    {
        static Timer t = new Timer();
        public static void MainFalso()
        {
            Console.CursorVisible = false;
            t.Elapsed += T_Elapsed;
            t.Interval = 100;
            t.Start();
            Console.ReadLine();
            t.Stop();
        }

        private static void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Write(DateTime.Now.Ticks);
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
        }
    }
}
