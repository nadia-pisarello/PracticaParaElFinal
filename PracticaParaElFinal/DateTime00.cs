using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class DateTime00
    {
        public static void MainFalso()
        {
            DateTime dt1 = DateTime.Now; 
            DateTime dt2 = new DateTime(2024, 09, 04, 15,0,0);
            DateTime dt3 = dt2.AddDays(7);
            Console.WriteLine("Fecha 1: {0}", dt1);
            Console.WriteLine("FEcha 2: {0}\n", dt2);

            //ToShortDateString acota fecha quitando la hora
            Console.WriteLine("Agregre 7 días a {1} con AddDays: {0}\n", dt3.ToShortDateString(), dt1.ToShortDateString());
            
            Console.WriteLine("El {0} de {1} cae el día {2}\n", dt3.Day, dt3.ToString("MMMM"), dt3.ToString("dddd", new CultureInfo("es-Es")));

            //Crear un intervalo de tiempo de 2 horas
            TimeSpan intervalo = new TimeSpan(2, 0, 0);

            //Suma el intervalo a la fecha dt1
            DateTime nuevaFecha = dt1 + intervalo;
            Console.WriteLine("Sumo intervalo de {1} horas a la fecha {2} y obtengo {0}\n", nuevaFecha, intervalo, dt1);

            //La diferencia de dos tipos iguales de DateTime devuelve un tipo TimeSpan.
            var dif = dt3 - dt2;
            var dif2 = dt1 - dt2;
            Console.WriteLine("La diferencia entre {0} y {1} es de {2} días", dt3.ToShortDateString(), dt2.ToShortDateString(), dif.TotalDays);
            Console.WriteLine("La diferencia entre {0} y {1} es de {2} minutos", dt1, dt2, dif2.TotalMinutes);
            if (dif.GetType().Name == dif2.GetType().Name)
            {
                Console.WriteLine("{0} días y {1} minutos son de tipo {2}.", dif.TotalDays, dif2.TotalMinutes, dif.GetType().Name);
            }
        }
    }
}
