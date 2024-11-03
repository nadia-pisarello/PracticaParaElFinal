using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracticaParaElFinal.Ahorcado
{
    public partial class AhorcadoForm : Form
    {
        StringBuilder palabraOculta;
        string[] arrayPalabras = Array.Empty<string>();
        //string[] arrPalabras = new string[] { "maravilla", "destino", "fortaleza","anacardos","edificios","hospitalario", "maquinaria", "proteccion", "decoracion"};
        static Random rand = new Random();
        string palabra;
        int intentos = 6;
        int cantidadDeSeries = 0;
        public AhorcadoForm()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lbMensajes.Visible = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            tbPalabraUsuario.Enabled = true;
            letraElegida.Enabled = true;
            CargarPalabrasDeArchivo();
            SeleccionarPalabra();
        }

        void CargarPalabrasDeArchivo()
        {
            string lineas = string.Empty;
            using(StreamReader sr = new StreamReader("palabras.txt"))
            {
                lineas = sr.ReadToEnd();
                arrayPalabras = lineas.Split(' ', '\n');
            }
        }

        void SeleccionarPalabra()
        {
            int indx = rand.Next(0, arrayPalabras.Length);
            palabra = arrayPalabras[indx];
            palabraOculta = new StringBuilder(new string('*',palabra.Length),50);
            lbpalabraOculta.Text = palabraOculta.ToString();
        }
              

        void VerificarPalabra()
        {
            if(tbPalabraUsuario.Text == palabra)
            {
                lbpalabraOculta.Text = palabra;
                MessageBox.Show("Has ganado!");
                cantidadDeSeries++;
                lbCantidadPalabrasDescubiertas.Text = cantidadDeSeries.ToString();
                Reiniciar();
            }
            else
            {
                tbPalabraUsuario.Clear();
            }
        }

        void VerificarLetra(char letra)
        {
            if ( palabra.Contains(letra))
            {
                for(int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == letra)
                    {
                        palabraOculta[i] = letra;
                    }
                }
                lbpalabraOculta.Text= palabraOculta.ToString();
                letraElegida.Clear();
            }
            else
            {
                RestarIntentos();
                letraElegida.Clear();
                lbMensajes.Text = "No se encuentra la letra : " + letra;
                lbMensajes.Visible = true;
                timer1.Start();
            }
        }

        void Reiniciar()
        {
            SeleccionarPalabra();
            tbPalabraUsuario.Clear() ;
            letraElegida.Clear();
            intentos = 6;
            cantidadDeIntentos.Text = intentos.ToString();           
        }

        private void letraElegida_TextChanged(object sender, EventArgs e)
        {
            if (letraElegida.Text.Length == 1)
            {
                char letra = letraElegida.Text[0];
                VerificarLetra(letra);
            }
            if(lbpalabraOculta.Text == palabra)
            {
                MessageBox.Show("Has ganado");
                cantidadDeSeries++;
                lbCantidadPalabrasDescubiertas.Text = cantidadDeSeries.ToString();
                Reiniciar();
            }
        }

        void RestarIntentos()
        {
            intentos--;
            cantidadDeIntentos.Text = intentos.ToString();
            if (intentos == 0)
            {
                MessageBox.Show("No tienes más intentos. Has perdido");
                Terminar();
            }
        }

        void tbPalabraUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si se presiona la tecla Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evitar el "ding" de la tecla Enter
                VerificarPalabra();
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
           Terminar();
        }

        void Terminar()
        {
            btnIniciar.Enabled = true;
            cantidadDeSeries = 0;
            lbCantidadPalabrasDescubiertas.Text = cantidadDeSeries.ToString();
            tbPalabraUsuario.Enabled = false;
            letraElegida.Enabled = false;
            lbMensajes.Visible = false;
            tbPalabraUsuario.Clear();
            letraElegida.Clear();
            intentos = 6;
            cantidadDeIntentos.Text = intentos.ToString();
            lbpalabraOculta.Text = string.Empty;
        }

        private void btnGuardarPartida_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)| *.txt| All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog1.FileName;
                string ultimaPartida = $"Jugador/a: {tbxJugador.Text}. Palabras Descubiertas: {cantidadDeSeries.ToString()}";
                using(StreamWriter sw = File.AppendText(rutaArchivo)) //para anexar contenido al viejo
                {
                    sw.WriteLine(ultimaPartida);
                }
            }
        }

        void tbxJugador_TextChanged(object sender, EventArgs e)
        {            
            tbxJugador.ForeColor = Color.Black;
        }
    }
}
