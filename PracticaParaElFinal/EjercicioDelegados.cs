using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    //Declaración del tipo
    public delegate void MiDelegado(string message);
    internal class EjercicioDelegados
    {
        public static void MainFalso()
        {
            //Instanciación - "method group conversion sintax"
            MiDelegado delegado = ClaseA.MetodoA;
            //Invocación
            delegado("Soy el delegado");
            delegado = ClaseB.MetodoB;
            EjecutarDelegado(delegado, "Delegado pasado como parámetro");
        }

        public static void EjecutarDelegado(MiDelegado del, string mensaje)
        {
            del(mensaje);
        }
        class ClaseA
        {
            public static void MetodoA(string msj)
            {
                Console.WriteLine("Llamado ClaseA.MetodoA() con parámetro: " + msj);
            }
        }
        class ClaseB
        {
            public static void MetodoB(string msj)
            {
                Console.WriteLine("Llamado ClaseB.MetodoB() con parámetro: " + msj);
            }
        }
        
    }
}
