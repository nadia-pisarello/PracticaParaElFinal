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

namespace Wordle_Sencillito
{
    public partial class WordleForm : Form
    {
        private List<Label> listaLabel;
        string lineas;
        private string[] palabras;
        private string palabraOculta = string.Empty;
        private string palabraSeleccionada = string.Empty;
        private string rutaArchivo = "C:\\Users\\pisar\\source\\repos\\PracticaParaElFinal\\Wordle Sencillito\\bin\\Debug\\palabras5Letras.txt";
        private static Random rnd = new Random();
        int intentos = 0;
        public WordleForm()
        {
            InitializeComponent();
            CargarArchivo();
            ListarLabels();
            palabraBox.Enabled = false;
            btnTerminar.Enabled = false;
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            if (nombreBox.Text == string.Empty) 
            {
                MessageBox.Show("Debes ingresar nombre de jugador antes de empezar", "Aviso", MessageBoxButtons.OK);
                return;
            }
            SeleccionarPalabra();
            ReiniciarIntentos();
            palabraBox.Enabled = true;
            btnTerminar.Enabled = true;
            btnIniciar.Enabled = false;

        }

        private void ReiniciarIntentos()
        {
            intentos = 0;
            intentosBox.Text = intentos.ToString();
        }

        private void CargarArchivo()
        {
            using ( StreamReader sr = new StreamReader(rutaArchivo))
            {
                lineas = sr.ReadToEnd();                
            }           
        }

        private void SeleccionarPalabra()
        {
            palabras = lineas.Split(' ');
            int index = rnd.Next(0, palabras.Length);
            palabraOculta = palabras[index];
        }
        private void ListarLabels()
        {
            listaLabel = new List<Label>();    
            foreach (Control c in labelPanel.Controls)
            {
                Label l = c as Label;
                listaLabel.Add(l);                
            }
            listaLabel.Reverse();
        }

        private void AsignarLetraALabel()
        {
            int index = 0;
            foreach ( Label l in listaLabel)
            {
                l.Text = palabraSeleccionada[index++].ToString();
            }

        }

        private void palabraBox_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                e.Handled = true;
                VerificarPalabra();
            }
        }

        private void VerificarPalabra()
        {
            palabraSeleccionada = palabraBox.Text.ToLower(); ;   
            if (palabraSeleccionada.Length != 5)
            {
                MessageBox.Show("Debe ser una palabra de 5 letras", "Aviso");
                return;
            }
            AsignarLetraALabel();
            int i = 0;
            foreach(Char c in palabraSeleccionada)
            {
                if (palabraOculta[i] == palabraSeleccionada[i])
                {
                    listaLabel[i].BackColor = Color.Red;
                }
                else if (palabraOculta.Contains(c))
                {
                    listaLabel[i].BackColor = Color.YellowGreen;
                }
                else
                {
                    listaLabel[i].BackColor = Color.Green;
                }
                i++;
            }
            VerificarGanador();
          
        }

        private void VerificarGanador()
        {
            foreach (Label l in listaLabel)
            {
                if(l.BackColor != Color.Red)
                {
                    intentos++;
                    intentosBox.Text = intentos.ToString();
                    return;
                }
            }
            MessageBox.Show("Has descubierto la palabra", "Ganaste!");
            ReiniciarJuego();
        }

        private void ReiniciarJuego()
        {
            SeleccionarPalabra();
            ReiniciarIntentos();
            ReestablerListaLabel();
            palabraBox.Text = string.Empty;
        }

        private void ReestablerListaLabel()
        {
            foreach(Label l in listaLabel)
            {
                l.BackColor = Color.White;
                l.Text = string.Empty;
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
            nombreBox.Text = string.Empty;
            palabraBox.Enabled = false;
            btnTerminar.Enabled = false;
            btnIniciar.Enabled = true;
        }
    }
}
