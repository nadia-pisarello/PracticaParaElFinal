using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class MetodoAnonimo
    {
        // Declaración delegado
        public delegate void MiDelegado(string msg);
        public static void MainFalso()
        {
            MiDelegado delegado;
            DateTime dt = DateTime.Now;
            // Declaración del método anónimo
            delegado = delegate (string s)
            {
                Console.WriteLine($"Método anónimo: {s} {dt}");
            };
            //Invocación
            delegado("Soy el legado");
        }
    }
}
