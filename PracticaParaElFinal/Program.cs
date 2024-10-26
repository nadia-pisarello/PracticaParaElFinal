
using System;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class Program
    {
       static void Main(string[] args)
       //static async Task Main() 
        {
            ProbandoCodigo00.MainFalso();
            ProbandoHerenciaConstructor.MainFalso();
            Array00.MainFalso();
            Array01.MainFalso();
            Moda.MainFalso();
            DateTime00.MainFalso();
            ManejoFecha.MainFalso();
            Biblioteca.MainFalso();
            Interfaces00.MainFalso();
            ColeccionesGenéricas.MainFalso();
            EjercicioComboBox.MainFalso();
            Archivos.MainFalso();
            SerializacionJson.MainFalso();
            DataReaderDataAdapter.MainFalso();
            DataSetNoTipado.MainFalso();
            DataTable00.MainFalso();
            Delegados.MainFalso();
            EventoDelegado.MainFalso();
            EventoEventHandler.MainFalso();
            EventoEventHandlerEventArgs.MainFalso();
            EventoTimer.MainFalso();
            MetodoAnonimo.MainFalso();
            Lambda00.MainFalso();
            DelegadoGenericosIncluidos.MainFalso();
            MetodoExtension.MainFalso();
            LINQ00.MainFalso();
            Thread00.MainFalso();
            ThreadTask00.MainFalso();

            //Usar static async Task Main() cuando se quiera probar este código
            await PatronAsincronismo.MainFalso();

            Console.ReadKey();
        }
    }
}
