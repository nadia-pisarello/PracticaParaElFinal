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

namespace PracticaParaElFinal.PicoFermiBagel
{
    public partial class HistorialForm : Form
    {

        List<JugadorPFB> jugadorPFBs = new List<JugadorPFB>();
        public HistorialForm()
        {
            InitializeComponent();
            CargarDatosHistorial();
        }

        void CargarDatosHistorial()
        {
            openFileDialog1.Filter = $"txt files (*.txt)| *.txt| All Files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;
                if (new FileInfo(rutaArchivo).Length == 0)
                {
                    MessageBox.Show("El archivo está vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stream fileStream = openFileDialog1.OpenFile();
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] jugador = linea.Split('-');
                        if (jugador.Length == 3)
                        {
                            jugadorPFBs.Add(new JugadorPFB(jugador[0], jugador[1], jugador[2]));
                        }
                    };
                }
                MostrarDatos();
            }
            if (jugadorPFBs.Count == 0)
            {
                MessageBox.Show("No se encontraron datos válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        void MostrarDatos()
        {          
            IEnumerable<JugadorPFB> query = jugadorPFBs.OrderBy(jugadorPFB => jugadorPFB.Tiempo).ToList(); // convierte el resultado de la consulta LINQ a una lista      
            dgvHistorial.DataSource = query;
        }
    }
}
