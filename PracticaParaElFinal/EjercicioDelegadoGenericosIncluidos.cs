using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class EjercicioDelegadoGenericosIncluidos
    {
        // Declaración delegado genérico
        // Debe ser estático para que esté en el mismo contexto.
        static Func<DateTime,bool> esFinDeSemana = delegate(DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Saturday ||
                   dt.DayOfWeek == DayOfWeek.Sunday;
        };
        public static void MainFalso()
        {
            // Expresión lambda equivalente
            esFinDeSemana = dt => dt.DayOfWeek == DayOfWeek.Sunday ||
                                  dt.DayOfWeek == DayOfWeek.Saturday;
            bool res = esFinDeSemana(DateTime.Now);
            Console.WriteLine("Es fin de semana: " + res);

            List<int> lista = new List<int>() { 6, 13, 4, 9, 3 };
            // Se crea una nueva lista con los números pares de la lista original
            // public int FindIndex(Predicate<T> match)
            List<int> filtro = lista.FindAll(n => n % 2 == 0);
            foreach (int i in filtro) 
            { 
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            // Se crea una nueva lista con los cuadrados de la lista original
            // public List>TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
            // Converter es un delegado ad-hoc
            List<int> foo = lista.ConvertAll(d => d * d);
            foreach (int i in foo)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
