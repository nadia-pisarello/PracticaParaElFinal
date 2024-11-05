using System;
using System.Windows.Forms;

namespace PracticaParaElFinal.Ahorcado
{
    internal class EjercicioAhorcado
    {
        [STAThread]
        public static void MainFalso()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AhorcadoForm());
            //// Código de consola después del formulario
            //Console.WriteLine("Formulario cerrado. Continúa la ejecución de la consola.");
            //Console.ReadKey();
        }
    }
}
