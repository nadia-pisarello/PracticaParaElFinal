using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class EnumeracionesYConstantes
    {
        internal enum Dias { Dom, Lun, Mar, Mier, Jue, Vier, Sab}
        internal enum Meses
        {
            Enero = 1,
            Febrero = 2,
            Marzo = 3,
            Abril = 4,
            Mayo = 5,
            Junio = 6,
            Julio = 7,
            Agosto = 8,
            Septiembre = 9,
            Octubre = 10,
            Noviembre = 11,
            Diciembre = 12
        }

        internal enum DiasByte: byte
        {
            Domingo,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado
        }
        internal const int numero = 10;
        internal static void MainFalso()
        {
            int x = (int)Dias.Lun;
            DiasByte y = DiasByte.Martes;
            Console.WriteLine("Dom = {0}", Dias.Dom);
            Console.WriteLine("Lun = {0}", x);
            Console.WriteLine("Mar = {0}", y);
            Console.WriteLine("Constante de la clase {0}", numero);
        }
    }
}
