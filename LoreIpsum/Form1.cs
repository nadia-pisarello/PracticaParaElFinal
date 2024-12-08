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

namespace LoreIpsum
{
    public partial class Form1 : Form
    {
        List<string> palabrasArchivo;
        readonly string rutaArchivo = "palabras.txt";
        readonly string textoPorDefecto = "Lorem ipsum dolor sit amet consectetur adipiscing elit. ";
        int totalPalabrasGeneradas;
        public Form1()
        {
            InitializeComponent();
            CargarArchivo();
        }

        private void CargarArchivo()
        {
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe");
                return;
            }
            palabrasArchivo = File.ReadAllLines(rutaArchivo).ToList();

            //string linea;
            //using(StreamReader sr = new StreamReader(rutaArchivo))
            //{
            //    while((linea = sr.ReadLine()) != null)
            //    {
            //        palabrasArchivo.Add(linea);
            //    }
            //}
        }

        private void Option_Click(object sender, EventArgs e)
        {
            if (palabraOption.Checked)
            {
                cantidadPalabrasBox.Enabled = true;
                cantMinimaPalabrasBox.Enabled = true;
                cantMaxPalabrasBox.Enabled= true;
                cantidadOracionesBox.Enabled = false;
                cantidadParrafosBox.Enabled = false;
            }
            else if (parrafoOption.Checked)
            {
                cantidadParrafosBox.Enabled = true;
                cantidadOracionesBox.Enabled = true;
                cantidadPalabrasBox.Enabled = false;
                cantMinimaPalabrasBox.Enabled = false;
                cantMaxPalabrasBox.Enabled = false;
            }
        }

        private void generarBtn_Click(object sender, EventArgs e)
        {
            totalPalabrasGeneradas = 0;
            textoGeneradoBox.Text = string.Empty;
            if (palabraOption.Checked)
            {
                if(
                    int.TryParse(cantidadPalabrasBox.Text,out int totalPalabras) &&
                    int.TryParse(cantMinimaPalabrasBox.Text,  out int min) &&
                    int.TryParse(cantMaxPalabrasBox.Text, out int max)
                    )
                {
                    VerificarMinyMax(min, max, totalPalabras);
                }
            }
            if (parrafoOption.Checked)
            {
                int cantOraciones, cantidadParrafos;
                if(
                    int.TryParse(cantidadParrafosBox.Text, out cantidadParrafos) &&
                    int.TryParse(cantidadOracionesBox.Text, out cantOraciones)
                    )
                {
                    GenerarTextoPorParrafo(cantOraciones, cantidadParrafos);
                }
            }
            totalPalabrasBox.Text = totalPalabrasGeneradas.ToString();
        }

        private void VerificarMinyMax(int min, int max, int total)
        {
            if (min > max || min > total || max > total || min < 0)
            {
                MessageBox.Show("El mínimo no puede ser mayor que al máximo o al total de palabras." +
                    "El mínimo no puede ser un número negativo" + 
                    "El máximo de palabras debe ser menor o igual al total");
                return;
            }
            GenerarTextoPorPalabras(min, max, total);
        }

        private void GenerarTextoPorPalabras(int min, int max, int total)
        {            
            if (textoDefectoOp.Checked)
            {
                GenerarTextoPorDefecto(max);
            }


        }
        private void GenerarTextoPorParrafo(int cantOraciones, int cantParrafos)
        {
        
        }


        private void GenerarTextoPorDefecto(int max)
        {
            string[] textoGenerador = textoPorDefecto.Split(' ');
            if (textoGenerador.Length <= max)
            {
                foreach (string str in textoGenerador)
                {
                    textoGeneradoBox.Text += str + " ";
                }
                textoGeneradoBox.Text.Trim();
            }
            else
            {
                for (int i = 0; i < max; i++)
                {
                    textoGeneradoBox.Text += textoGenerador[i] + " ";
                }
                textoGeneradoBox.Text = textoGeneradoBox.Text.Trim();
                textoGeneradoBox.Text += ".";
            }
            totalPalabrasGeneradas = textoGeneradoBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
