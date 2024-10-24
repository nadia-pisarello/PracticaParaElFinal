using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class EjercicioDataReaderDAdapter
    {
        public static void MainFalso()
        {
            int idPaciente;
            MostrarPacientes();
            ContarRegistros();
            //Console.WriteLine("Ingresar número de ficha a eliminar:");
            //if (Int32.TryParse(Console.ReadLine(), out idPaciente))
            //{
            //    EliminarPaciente(idPaciente);
            //}
          
        }

        static string GetConnectionString()
        {
            return @"Data Source=MSI;Initial Catalog=consultas;Integrated Security=True;TrustServerCertificate=True";
        }

        public static void ContarRegistros()
        {
            string selectSQL = "Select count(*) from pacientes"; 
            using (SqlConnection cn = ObtenerConexion())
            {
                //SqlCommand cmd = new SqlCommand(selectSQL, cn);
                // Forma Alternativa
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = selectSQL;
                Console.WriteLine("Cantidad de registros : " + cmd.ExecuteScalar());

            }
        }

        static public void MostrarPacientes()
        {
            using (SqlConnection cn = ObtenerConexion())
            {
                string selectSQL = "Select [id],[nombre],[apellido] From pacientes";                
                //Console.WriteLine(cn.State);
                SqlCommand myCommnand = new SqlCommand(selectSQL, cn);
                using (SqlDataReader myDR = myCommnand.ExecuteReader())
                {
                    if (!myDR.HasRows)
                    {
                        Console.WriteLine("No se encontraron registros en la tabla pacientes.");
                    }

                    while (myDR.Read())
                    {
                        Console.WriteLine("Ficha {0}, Nombre: {1} {2}", myDR["id"], myDR["nombre"].ToString(), myDR["apellido"].ToString());
                    }
                }
            }
        }

        static void EliminarPaciente(int idPaciente)
        {
            string selectSQL = "Select * From pacientes";
            using(SqlConnection cn = ObtenerConexion())
            {
                
                SqlDataAdapter adapter = new SqlDataAdapter(selectSQL, cn);
                DataTable pacientesTabla = new DataTable();
                adapter.Fill(pacientesTabla);
                // Definir la clave primaria en el DataTable
                DataRow filaABorrar = pacientesTabla.Rows.Find(idPaciente);
                if(filaABorrar != null)
                {
                    filaABorrar.Delete();
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    // UpdateCommand se generá automáticamente por el SqlCommnadBuilder cuando se llama a Update
                    adapter.Update(pacientesTabla);
                    Console.WriteLine("Paciente eliminado con éxito");
                    MostrarPacientes();
                }
                else
                {
                    Console.WriteLine("Paciente no encontrado.");
                }
            }
        }

        static SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = GetConnectionString();
            cn.Open();
            return cn;
        }

    }
}
