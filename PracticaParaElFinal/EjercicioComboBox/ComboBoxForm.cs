using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            //binding.DataSource = GetPacientes();
            comboBox1.DataSource = binding;
            CargarRegistroPacientes();
            /* Funciona con GetPacientes */
            //comboBox1.ValueMember = "id";
            //comboBox1.DisplayMember = "nombre";
            datosCargados = true;
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
                    binding.Add(paciente); // Agregar al BindingSource
                }
            }
        }

        private DataTable GetPacientes()
        {
            SqlConnection cn = new SqlConnection(stringCn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select id, nombre, apellido from pacientes",cn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            // Llenar DataTable
            DataSet ds = new DataSet();
            adapter.Fill(ds, "pacientes");
            return ds.Tables["pacientes"];
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Funciona con CargarRegistroPacientes */
            if (datosCargados && comboBox1.SelectedItem is Paciente selectedPaciente)
            {
                CargarTurno(selectedPaciente.Id, stringCn);
            }

            /* Funciona con GetPacientes */
            //if (datosCargados && comboBox1.SelectedValue is int seletedId)
            //{
            //    CargarTurno(seletedId, stringCn);
            //}
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
                    MessageBox.Show($"Fecha: {turno.FechaTurno} - Hora: {turno.HoraTurno}\n" +
                        $"Motivo: {turno.Motivo}");
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
