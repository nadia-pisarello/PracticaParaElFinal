using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PracticaParaElFinal
{
    public partial class ComboBoxForm : Form
    {
        string stringCn = "Data Source=MSI;Initial Catalog=consultas;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        BindingSource binding = new BindingSource();
        bool datosCargados = false;
        public ComboBoxForm()
        {
            InitializeComponent();
            //CrearBiblioteca();
            CargarRegistroPacientes();
            datosCargados=true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Libro item = (Libro)comboBox1.SelectedItem;
            //MessageBox.Show(String.Format($"{item.Autor} - {item.Titulo}"));

            if (datosCargados && comboBox1.SelectedItem is Paciente selectedPaciente)
            {
                CargarTurno(selectedPaciente.Id,stringCn);
                //MessageBox.Show($"{selectedPaciente.Nombre} {selectedPaciente.Apellido}");
            }
        }

        void CrearBiblioteca()
        {
            comboBox1.Items.Add(new Libro("Nami", "Bitacora"));
            comboBox1.Items.Add(new Libro("Tony Tony Chopper", "Atlas de un Reno"));
            comboBox1.Items.Add(new Libro("Nico Robin", "El Gran Río"));
        }

        public void CargarRegistroPacientes()
        {
            using (SqlConnection cn = new SqlConnection(stringCn))
            {
                cn.Open();
                string selectSQL = "Select id, nombre, apellido from pacientes";
                SqlCommand cm = new SqlCommand(selectSQL, cn);
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                    Paciente paciente = new Paciente
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString()
                    };
                    comboBox1.Items.Add(paciente);
                }
            }                    
        }

        public class Paciente
        {
            private int id;
            private string nombre;
            private string apellido;

            public int Id { get=> id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }

            public override string ToString()
            {
                return $"{Nombre} {Apellido}";
            }
        }

        static void CargarTurno(int id, string cnString)
        {
            using (SqlConnection cn = new SqlConnection(cnString))
            {
                cn.Open();
                string selectSQL = $"Select * from turno Where pacienteId = @pacienteId";                
                SqlCommand cm = new SqlCommand(selectSQL , cn);
                cm.Parameters.AddWithValue("@pacienteId", id);
                SqlDataReader reader = cm.ExecuteReader();
                while (reader.Read())
                {
                   
                    Turno turno = new Turno
                   {
                       PacienteId = Convert.ToInt32(reader["pacienteId"]),
                       FechaTurno = (DateTime.Parse(reader["fechaTurno"].ToString())),
                       HoraTurno = DateTime.Parse(reader["horaTurno"].ToString()),
                       Motivo = reader["motivo"].ToString(),
                   };
                    MessageBox.Show($"{turno.FechaTurno} - {turno.HoraTurno}\n" +
                        $"{turno.Motivo}");
                }

            }
        }

        class Turno
        {
            private int pacienteId;
            private DateTime fechaTurno;
            private DateTime horaTurno;
            private string motivo;

            public int PacienteId { get => pacienteId; set => pacienteId = value;}
            public DateTime FechaTurno { get => fechaTurno; set => fechaTurno = value; }
            public DateTime HoraTurno { get => horaTurno; set => horaTurno = value; }
            public string Motivo { get => motivo; set => motivo = value; }
        }
    }
}
