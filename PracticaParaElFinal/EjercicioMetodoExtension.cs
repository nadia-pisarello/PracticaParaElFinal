using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal static class EjercicioMetodoExtension    {
        public static void MainFalso()
        {
            int i = 6;            
            if (i.EsPar()){
                Console.WriteLine($"i vale {i}, es Par");
            }
            /*Los métodos de extensión se definen como métodos estáticos,
             * pero se les llama usando la sintaxis de método de instancia.*/
            i.Sumar(9);
            Console.WriteLine("Después de aplicar método Sumar, i ahora vale " + i);
        }
        public static bool EsPar(this int i)
        {
            return i % 2 == 0;
        }
        public static void Sumar (this ref int i, int j)
        {
            i += j;
        }
    }
}
