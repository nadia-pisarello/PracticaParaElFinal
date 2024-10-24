using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class EjercicioLambda
    {
        // Declaración delegado
        public delegate bool EsFinDeSemana(DateTime dt);

        public static void MainFalso()
        {
            // Instanciación delegado
            EsFinDeSemana esFinDeSemana = delegate (DateTime dt)
            {
                return dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday;
            };

            // Expresión lambda equivalente
            esFinDeSemana = dt => dt.DayOfWeek == DayOfWeek.Saturday ||
                                  dt.DayOfWeek == DayOfWeek.Sunday;
            bool res = esFinDeSemana(DateTime.Now);

            Console.WriteLine("Es fin de semana hoy: " + res);
        }
    }
}
