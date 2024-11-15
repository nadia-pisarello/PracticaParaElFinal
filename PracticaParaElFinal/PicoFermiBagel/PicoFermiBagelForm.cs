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

namespace PracticaParaElFinal.PicoFermiBagel
{
    public partial class PicoFermiBagelForm : Form
    {
        string[] pistas = new string[] { "Pico", "Fermi", "Bagel" };
        static Random rand = new Random();
        string numeroSecreto = string.Empty;
        string numeroJugador = string.Empty;
        int indxNumJugador = 0;
        List<TextBox> listTbxPistas = new List<TextBox>();
        int puntaje;
        Stopwatch stopwatch = new Stopwatch();

        public PicoFermiBagelForm()
        {
            InitializeComponent();
            GenerarListTextBoxPistas();
        }

        private void IniciarMenu_Click(object sender, EventArgs e)
        {
            if (tboxJugador.Text == string.Empty)
            {
                MessageBox.Show("Debes ingresar tu nombre antes de iniciar");
                return;
            }
            //SeleccionarNumero();
            numeroSecreto = "377";
            HabilitarBotones();
            iniciarToolStripMenuItem.Enabled = false;
            puntaje = 0;
            tboxPuntaje.Text = puntaje.ToString();
            stopwatch.Start();
        }

        void SeleccionarNumero()
        {
            numeroSecreto = rand.Next(100,1000).ToString();
        }
        private void ReiniciarMenu_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void GuardarMenu_Click(object sender, EventArgs e)
        {
            GuardarPartida();
        }

        void GuardarPartida()
        {
            saveFileDialog1.Filter = "txt files (*.txt)| *.txt| All files (*.*)| *,*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog1.FileName;
                string ultimaPartida = $"{tboxJugador.Text}-{tboxPuntaje.Text}-{tboxTiempo.Text}";
                using (StreamWriter sw = File.AppendText(rutaArchivo))
                {
                    sw.WriteLine(ultimaPartida);
                }

            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button digito = sender as Button;
            numeroJugador += digito.Text;
            switch (indxNumJugador)
            {
                case 0: tbxDigito1.Text = numeroJugador[0].ToString(); break;
                case 1: tbxDigito2.Text = numeroJugador[1].ToString(); break;
                case 2: tbxDigito3.Text = numeroJugador[2].ToString(); break;
            }
            indxNumJugador++;
        }

        void EnviarNumero_Click(object sender, EventArgs e)
        {
            MostrarPistas();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (indxNumJugador > 0)
            {
                indxNumJugador--;
                numeroJugador = numeroJugador.Remove(indxNumJugador);
                switch (indxNumJugador)
                {
                    case 0: tbxDigito1.Text = ""; break;
                    case 1: tbxDigito2.Text = ""; break;
                    case 2: tbxDigito3.Text = ""; break;
                }
            }           
        }

        void MostrarPistas()
        {            
            for(int i = 0; i < numeroJugador.Length; i++) 
            {
                if (numeroSecreto.Contains( numeroJugador[i].ToString()) &&  numeroJugador[i] == numeroSecreto[i])
                {
                    listTbxPistas[i].Text = $"{numeroJugador[i]}: {pistas[0]}";
                }
                else if (numeroSecreto.Contains(numeroJugador[i].ToString()) && listTbxPistas[i].Text != pistas[0].ToString() )
                {
                    listTbxPistas[i].Text = $"{numeroJugador[i]}: {pistas[1]}";
                }
                else
                {
                    listTbxPistas[i].Text = $"{numeroJugador[i]}: {pistas[2]}";
                }
                
            }
            VerificarGanador();
        }

        void VerificarGanador()
        {
            if (numeroJugador.Equals(numeroSecreto))
            {
                ObtenerTiempo();
                puntaje++;
                tboxPuntaje.Text = puntaje.ToString();
                DialogResult res = MessageBox.Show("Probamos otro número","Has Acertado!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {                    
                    GuardarPartida();
                    NuevoNumero();
                }
                else
                {
                    GuardarPartida();
                    Reiniciar();
                    return;
                }               
            }
            else
            {
                LimpiarZonaJugador();
            }
        }

        void ObtenerTiempo()
        {
            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            tboxTiempo.Text = time.TotalSeconds.ToString();
        }

        void LimpiarZonaJugador()
        {
            LimpiarTextBoxDigitos();
            BorrarInfoNumeroJugador();
        }

        void LimpiarTextBoxDigitos()
        {
            tbxDigito1.Text = string.Empty;
            tbxDigito2.Text = string.Empty;
            tbxDigito3.Text = string.Empty;
        }

        void GenerarListTextBoxPistas()
        {            
            listTbxPistas.Add(tbxPista1);
            listTbxPistas.Add(tbxPista2);
            listTbxPistas.Add(tbxPista3);
        }

        void HabilitarBotones()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if(c is Button button) button.Enabled = true;
            }
            btnSgteNumero.Enabled = true;
            reiniciarToolStripMenuItem.Enabled = true;
            reiniciarToolStripMenuItem.Enabled = true ;
            guardarToolStripMenuItem.Enabled = true;
        }

        private void btnSgteNumero_Click(object sender, EventArgs e)
        {
                NuevoNumero();
        }

        void NuevoNumero()
        {
            SeleccionarNumero();
            LimpiarTextBoxDigitos();
            LimpiarPistar();
            BorrarInfoNumeroJugador();
            tboxJugador.Text = numeroSecreto;
        }

        void LimpiarPistar()
        {
            tbxPista1.Text = string.Empty;
            tbxPista2.Text = string.Empty;
            tbxPista3.Text = string.Empty;
        }

        void BorrarInfoNumeroJugador()
        {
            numeroJugador = string.Empty;
            indxNumJugador = 0;
        }

        void Reiniciar()
        {
            InhabilitarBotones();
            LimpiarZonaJugador();
            LimpiarTextBoxDigitos();
            LimpiarPistar();
            tboxJugador.Text = string.Empty;
            iniciarToolStripMenuItem.Enabled = true;      
            tboxTiempo.Text = string.Empty;
            tboxPuntaje.Text = string.Empty;
        }

        void InhabilitarBotones()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button b) b.Enabled = false;
            }
            btnSgteNumero.Enabled = false;
            reiniciarToolStripMenuItem.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
        }

        private void MostrarHistorial_Click(object sender, EventArgs e)
        {
            Form form = new HistorialForm();
            form.ShowDialog();
        }
       
    }
}
