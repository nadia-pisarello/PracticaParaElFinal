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

namespace PracticaParaElFinal.Recetario
{
    public partial class RecetarioForm : Form
    {
        List<Receta> recetas = new List<Receta>();
        string[] receta = new string[] { };
        string[] postres = { "azúcar", "chocolate", "crema", "dulce" };
        string[] principales = { "carne", "pollo", "arroz", "pasta" };
        string[] entradas = { "sopa", "ensalada", "aperitivo", "acompañamiento" };
        string[] bebidas = { "jugo", "café", "té", "licor" };
        public RecetarioForm()
        {
            InitializeComponent();
        }

        private void AbrirArchivo_Click(object sender, EventArgs e)
        {
            dgvRecetas.DataSource = null;
            string linea = string.Empty;
            string categoria = string.Empty;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "txt files (*.txt)| *.txt| All files (*.*)|*.*";
            string rutaArchivo = string.Empty;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                rutaArchivo = openFileDialog1.FileName;
                using(StreamReader sr = new StreamReader(rutaArchivo))
                {
                    while((linea = sr.ReadLine()) != null)
                    {
                        if(!string.IsNullOrEmpty(linea) && linea.Contains(';'))
                        {
                            receta = linea.Split(';');
                            if (receta.Length == 2)
                            {
                                categoria = CategorizarReceta(receta[1]);
                            }
                            recetas.Add(new Receta(receta[0], receta[1], categoria));
                        }                       
                    }
                }
            }
            dgvRecetas.DataSource = recetas;
            categoríaMenu.Enabled = true;
        }
        string CategorizarReceta(string descripcion)
        {
            string categoria = string.Empty;
            if (descripcion.Length > 0) 
            {
                foreach (string s in postres)
                {
                    if (descripcion.Contains(s))
                    {
                        categoria = "postres";
                    }
                }
                foreach (string s in principales)
                {
                    if (descripcion.Contains(s))
                    {
                        categoria = "principales";
                    }
                }
                foreach (string s in bebidas)
                {
                    if (descripcion.Contains(s))
                    {
                        categoria = "bebidas";
                    }
                }
                foreach (string s in entradas)
                {
                    if (descripcion.Contains(s))
                    {
                        categoria = "entradas";
                    }
                }
            }
            return categoria;
        }

        private void VerCategoria_Click(object sender, EventArgs e)
        {
            List<Receta> recetaCategorizada = new List<Receta>();
            string categoria = string.Empty;
            if(sender is ToolStripMenuItem item)
            {
                categoria = item.Text.ToLower();               
            }
            foreach (Receta receta in recetas)
            {
                if (receta.Categoria.ToLower() == categoria)
                {
                    recetaCategorizada.Add(receta);
                }
            }

            dgvRecetas.DataSource = null; // para limpiar lo anterior
            dgvRecetas.DataSource = recetaCategorizada;
        }

        private void cerrarArchivo_Click(object sender, EventArgs e)
        {
            dgvRecetas.DataSource = null;
            recetas.Clear();
        }
    }
}
