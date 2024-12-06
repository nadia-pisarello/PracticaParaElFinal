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

namespace TaTeTi
{
    public partial class HistorialForm : Form
    {
        private string rutaArchivo = "historialTaTeTi.txt";
        DataTable dt;
        public HistorialForm()
        {
            InitializeComponent();
            CrearDataTable();
            CargarArchivo();
        }

        private void CargarArchivo()
        {
         
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string contenidoArchivo;
                while ((contenidoArchivo = sr.ReadLine()) != null)
                {
                    string[] arr = contenidoArchivo.Split(' ');
                    dt.Rows.Add(arr);
                }
                dt.DefaultView.Sort = "Movimientos";
                dgvHistorial.DataSource = dt;
            }
        }

        private void CrearDataTable()
        {           
            dt = new DataTable();
            dt.Columns.Add("Jugador");
            dt.Columns.Add("Movimientos");
        }
    }
}
