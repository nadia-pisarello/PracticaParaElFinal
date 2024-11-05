using System;
using System.Diagnostics;
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
        TimeSpan tiempoJugando;
        Stopwatch stopwatch = new Stopwatch();
        public AhorcadoForm()
        {
            InitializeComponent();
            this.FormClosing += AhorcadoForm_FormClosing;
            timer1.Interval = 2000;
            timer1.Tick += Timer1_Tick;
        }   

        private void AhorcadoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult result = MessageBox.Show("Desea guardar la partida antes de cerrar?", "Atencion", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)  // si elige 'No', el formulario se cierra
            {
                GuardarPartida();  // llama al método para guardar el juego y luego se cierra el formulario
            }
            else if(result == DialogResult.Cancel)
            {
                e.Cancel = true; // cancela el cierre del formulario
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lbMensajes.Visible = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)        
        {      
            if(string.IsNullOrEmpty(tbxJugador.Text) || tbxJugador.Text == "Ingresa tu nombre...")
            {
                MessageBox.Show("Debes ingresar un nombre de jugador para poder iniciar el juego");
                return;
            }
            btnTerminar.Enabled = true;
            btnIniciar.Enabled = false;
            tbPalabraUsuario.Enabled = true;
            letraElegida.Enabled = true;
            CargarPalabrasDeArchivo();
            SeleccionarPalabra();
            stopwatch.Start();            
        }

        void CargarPalabrasDeArchivo()
        {
            string lineas = string.Empty;
            string file = "palabras.txt";
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    lineas = sr.ReadToEnd();
                    arrayPalabras = lineas.Split(' ', '\n');
                }
            }
            else
            {
                SeleccionarArchivo();
            }
            
        }

        string SeleccionarArchivo()
        {
            string fileName = string.Empty;
            openFileDialog1.Title = "Selecciona un archivo";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "txt files (*.txt)| *txt| All files (*.*)|*.*";
            openFileDialog1.FileName = string.Empty;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }
            return fileName ;
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
            if(arrayPalabras.Length == 0)
            {
                MessageBox.Show("No quedan más palabras. ¡Felicidades, has completado el juego!");
                Terminar();
                return;
            }
            arrayPalabras = arrayPalabras.Where(e => e != palabra).ToArray();
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
                MessageBox.Show($"No tienes más intentos. Solución {palabra}", "Has perdido");
                MarcarTiempo();
                DialogResult resutl = MessageBox.Show("Deseas guardar la partida?","Guardar Partida" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resutl == DialogResult.Yes) GuardarPartida();
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
            btnTerminar.Enabled = false;
            btnIniciar.Enabled = true;
            tiempoJugando.Subtract(tiempoJugando);
        }

        private void btnGuardarPartida_Click(object sender, EventArgs e)
        {
           GuardarPartida();
        }

        void tbxJugador_TextChanged(object sender, EventArgs e)
        {            
            tbxJugador.ForeColor = Color.Black;

        }

        void GuardarPartida()
        {
            saveFileDialog1.Filter = "txt files (*.txt)| *.txt| All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog1.FileName;
                string ultimaPartida = $"Jugador/a: {tbxJugador.Text}. Palabras Descubiertas: {cantidadDeSeries.ToString()}. Tiempo de Juego: {tiempoJugando.TotalSeconds}";
                using (StreamWriter sw = File.AppendText(rutaArchivo)) //para anexar contenido al viejo
                {
                    sw.WriteLine(ultimaPartida);
                }
            }
        }

        void MarcarTiempo()
        {
            stopwatch.Stop();
            tiempoJugando = stopwatch.Elapsed;
        }
    }
}
