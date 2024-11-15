using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParaElFinal.Recetario
{
    internal class EjercicioRecetario
    {
        [STAThread]
        public static void MainFalso()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RecetarioForm());
        }
    }
}
