using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class ProbandoCodigo00
    {
        public static void MainFalso()
        {
            int[] x = { 1, 2, 3, 6 };
            try
            {
                Console.WriteLine("Bloque try --> {0}\n", x.GetUpperBound(0));
                Console.WriteLine(x.GetUpperBound(1));

            } catch (Exception e){
                Console.WriteLine("Bloque catch --> {0}\n", e.ToString());
            }
            finally
            {
                Console.WriteLine("Bloque finally --> x.GetUpperBound(0)");
            }
        }
    }
}
