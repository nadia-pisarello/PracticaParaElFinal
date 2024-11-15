using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMemoria
{
    public partial class JuegoMemoriaForm : Form
    {

        private string rutaArchivo = "words - copia.txt";
        private List<string> palabrasJuego;
        private List<Button> listaBotones;
        private static Random rnd = new Random();
        private Button primerBoton = null;
        private Button segundoBoton = null;
        private int intentos;
        public JuegoMemoriaForm()
        {
            InitializeComponent();
            CargarArchivo();
            DeshabilitarBotones();
            IniciarIntentos();
            timer1.Interval = 1000;
            timer1.Tick += timer_Tick;
            btnTerminar.Enabled = false;            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (nombreBox.Text == string.Empty) 
            {
                MessageBox.Show("Debes ingresar nombre de jugador para iniciar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnIniciar.Enabled = false;
            nombreBox.ReadOnly = true;
            Iniciar();
            btnTerminar.Enabled = true;
        }

        private void Iniciar()
        {
            CargarBotones();
            MezclarPalabras(palabrasJuego);
            AsignarPalabraABoton();
            panelBotones.Enabled = true;
            IniciarIntentos();
        }

        private void IniciarIntentos()
        {
            intentos = 20;
            intentosBox.Text = intentos.ToString();
        }

        private void Reiniciar()
        {
            MezclarPalabras(palabrasJuego);
            listaBotones.Clear();
            ReestablecerBotones();
            CargarBotones();
            AsignarPalabraABoton();
            IniciarIntentos();            
        }

        private void Terminar()
        {
            btnIniciar.Enabled = true;
            btnTerminar.Enabled = false;
            ReestablecerBotones();
            listaBotones.Clear();
            IniciarIntentos();
            panelBotones.Enabled = false;
            nombreBox.ReadOnly = false;
            nombreBox.Text = string.Empty;
        }

        private void CargarArchivo()
        {
            palabrasJuego = new List<string>();
            using (StreamReader sr = new StreamReader(rutaArchivo)) 
            {
                string palabra;
                while ((palabra = sr.ReadLine()) != null)
                {
                    palabrasJuego.Add(palabra);
                    palabrasJuego.Add(palabra);
                }                
            }
        }

        private void MezclarPalabras(List<string> lista)
        {
            palabrasJuego = lista.OrderBy(x => rnd.Next()).ToList();
        }

        private void CargarBotones()
        {
            listaBotones = new List<Button>();
            foreach(Control c in panelBotones.Controls)
            {
                if(c is Button btn)
                { listaBotones.Add(btn); }
            }
        }

        private void AsignarPalabraABoton()
        {
            int index = 0;
            foreach(Button btn in listaBotones)
            {
                btn.Text = palabrasJuego[index++];
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
             
            if (timer1.Enabled == true) return;
            if (sender is Button btn)
            {
                if(btn != null)
                {
                    if (btn.ForeColor == Color.Black) return;
                    if(primerBoton == null)
                    {
                        primerBoton = btn;
                        primerBoton.ForeColor = Color.Black;
                        return;
                    }
                    segundoBoton = btn;
                    segundoBoton.ForeColor = Color.Black;
                    VerificarGanador();
                    if (primerBoton.Text == segundoBoton.Text)
                    {
                        ReestablecerEstadosAuxBtn();
                        return;
                    }
                    timer1.Start();
                }             
            }            
        }

        private void ReestablecerEstadosAuxBtn()
        {
            primerBoton = null;
            segundoBoton = null;
        }

        private void DescontarIntentos()
        {
            intentos--;
            intentosBox.Text = intentos.ToString();
            if (intentos == 0)
            {
                DialogResult result = MessageBox.Show("Te quedaste sin intentos ¿Deseas probar de nuevo?", "Has perdido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Reiniciar();
                }
                else
                {
                    Terminar();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            primerBoton.ForeColor = primerBoton.BackColor;
            segundoBoton.ForeColor = segundoBoton.BackColor;
            ReestablecerEstadosAuxBtn();
            DescontarIntentos();
        }

        private void VerificarGanador()
        {
            foreach(Control c in panelBotones.Controls)
            {
                Button btn = c as Button;
                if ( btn != null)
                {
                    if (btn.ForeColor == btn.BackColor) { return; }

                }
            }
            DialogResult result = MessageBox.Show("Completaste todas las parejas.\n ¿Quieres jugar de nuevo?", "Has ganado", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Reiniciar();
            }
            else
            {
                Terminar();
            }
        }

        private void CargarArchivo2()
        {
            palabrasJuego = new List<string>();
            string[] lineas = File.ReadAllLines(rutaArchivo);
            palabrasJuego.AddRange(lineas);
            palabrasJuego.AddRange(lineas);
        }

        private void DeshabilitarBotones()
        {
            panelBotones.Enabled = false;
        }

        private void ReestablecerBotones()
        {
            foreach (Control c in panelBotones.Controls)
            {
                Button btn = c as Button;
                if (btn != null)
                {
                    btn.ForeColor = btn.BackColor;
                    btn.Text = string.Empty;
                }
            }
        }

        private void Terminar_Click(object sender, EventArgs e)
        {
            Terminar();
        }
    }
}
