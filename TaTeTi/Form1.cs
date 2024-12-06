using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaTeTi
{
    public partial class TaTeTiForm : Form
    {
        int movimientos;
        int movimientosTotalesJ1;
        int movimientosTotalesJ2;
        static Random rnd = new Random();
        List<Label> labelsTablero = new List<Label>();
        string marca;
        bool modo1vsPc = false;
        public TaTeTiForm()
        {
            InitializeComponent();
            tableroPanel.Enabled = false;
            ListaLabel();
        }

        private void iniciarBtn_Click(object sender, EventArgs e)
        {
            if(jugador1Box.Text == string.Empty && jugador2Box.Text == string.Empty )
            {
                MessageBox.Show("Debes ingresar al menos un nombre para iniciar");
            }
            else if (jugador1Box.Text == string.Empty)
            {
                jugador1Box.Text = "Computadora";
                modo1vsPc = true;
            }
            else if (jugador2Box.Text == string.Empty)
            {
                jugador2Box.Text = "Computadora";
                modo1vsPc = true;
            }
            Iniciar();
        }

        void Iniciar()
        {
            marca = "O";
            movimientos = 9;
            tableroPanel.Enabled = true;
            LimpiarTablero();
            movimientosTotalesJ1 = 0;
            movimientosTotalesJ2 = 0;
        }

        void ListaLabel()
        {
            labelsTablero.Clear();
            foreach (Control control in tableroPanel.Controls)
            {
                Label label = control as Label;
                labelsTablero.Add(label);
            }
        }

        private void Label_Click (object sender, EventArgs e)
        {
            Label l = sender as Label;
            if(l.Text != string.Empty) { return; }
            marca = ( marca == "X" ) ? "O":"X";
            l.Text = marca;
            if(modo1vsPc == false)
            {
                SumarMovimientos();
            }
        
            VerificarGanador();
            if (modo1vsPc)
            {
                Modo1vsPc();
                return;
            }            
        }

        private void SumarMovimientos()
        {
            if (marca == "X")
            {
                movimientosTotalesJ1++;
            }
            else
            {
                movimientosTotalesJ2++;
            }
        }

            private void ControlarCantidadDeMovimientos()
        {
            movimientos--;
            if (movimientos == 0) 
            {
                MessageBox.Show("Ya no hay mas jugadas posibles");
                return;
            }
        }

        private void VerificarGanador()
        {
           if((labelsTablero[0].Text == labelsTablero[1].Text && labelsTablero[0].Text == labelsTablero[2].Text && labelsTablero[0].Text != string.Empty)
                || (labelsTablero[3].Text == labelsTablero[4].Text && labelsTablero[3].Text == labelsTablero[5].Text && labelsTablero[3].Text != string.Empty)
                || (labelsTablero[6].Text == labelsTablero[7].Text && labelsTablero[6].Text == labelsTablero[8].Text && labelsTablero[6].Text != string.Empty)
                || (labelsTablero[0].Text == labelsTablero[4].Text && labelsTablero[0].Text == labelsTablero[8].Text && labelsTablero[0].Text != string.Empty)
                || (labelsTablero[6].Text == labelsTablero[4].Text && labelsTablero[6].Text == labelsTablero[2].Text && labelsTablero[6].Text != string.Empty)
                || (labelsTablero[0].Text == labelsTablero[3].Text && labelsTablero[0].Text == labelsTablero[6].Text && labelsTablero[0].Text != string.Empty)
                || (labelsTablero[1].Text == labelsTablero[4].Text && labelsTablero[1].Text == labelsTablero[7].Text && labelsTablero[1].Text != string.Empty)
                || (labelsTablero[2].Text == labelsTablero[5].Text && labelsTablero[2].Text == labelsTablero[8].Text && labelsTablero[2].Text != string.Empty)
                )
           {
                if(modo1vsPc == false)
                {
                    GuardarGanador(); 
                }
                MessageBox.Show("Juego Terminado", "Tenemos un ganador");
                tableroPanel.Enabled = false;
                modo1vsPc = false;
           }
           ControlarCantidadDeMovimientos();
        }

        private void GuardarGanador()
        {
            string ganador = (marca == "X") ? jugador1Box.Text : jugador2Box.Text;            
            int movimientosTotales = (marca == "X") ? movimientosTotalesJ1 : movimientosTotalesJ2;
            string rutaArchivo = "historialTaTeTi.txt";

            using (StreamWriter sw = new StreamWriter(rutaArchivo, true)) 
            {
                sw.WriteLine($"{ganador} {movimientosTotales}");
            }
        }

        private void LimpiarTablero()
        {
            foreach (Label label in labelsTablero)
            {
                label.Text = string.Empty;
            }
        }

        private void Modo1vsPc()
        {
            List<int> indiceLabelVacio = new List<int>() ;
            foreach(Label label in labelsTablero)
            {
                if(label.Text == string.Empty)
                {
                    indiceLabelVacio.Add(labelsTablero.IndexOf(label)); 
                }
            }
            int indx = rnd.Next(indiceLabelVacio.Count);
            marca = (marca == "X") ? "O" : "X";
            labelsTablero[indiceLabelVacio[indx]].Text = marca;
            VerificarGanador();
        }

        private void historialBtn_Click(object sender, EventArgs e)
        {
            Form form = new HistorialForm();
            form.ShowDialog();
        }
    }
}
