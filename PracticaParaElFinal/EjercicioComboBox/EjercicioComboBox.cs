﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParaElFinal
{
    internal class EjercicioComboBox
    {
        [STAThread]
        public static void MainFalso()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ComboBoxForm());
            // Código de consola después del formulario
            Console.WriteLine("Formulario cerrado. Continúa la ejecución de la consola.");
            Console.ReadLine();
        }
    }
}