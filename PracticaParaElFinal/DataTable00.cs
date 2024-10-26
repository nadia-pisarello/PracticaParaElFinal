using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    public class DataTable00
    {
        public static void MainFalso()
        {
            DataTable tablaInventario = CrearTabla();
            CrearColumnaID(tablaInventario);
            CrearOtrasColumnas(tablaInventario);
            AgregarFilas(tablaInventario);
            foreach(DataRow row in tablaInventario.Rows)
            {
                Console.WriteLine($"Id: {row["CarID"]}, Marca: {row["Marca"]}, Color: {row["Color"]}");
                //Console.WriteLine("CarID: {0}, Marca: {1}, Color: {2}", row["CarID"], row["Marca"], row["Color"]);
            }
            Console.WriteLine("Ingrese marca del vehículo");
            string marca = Console.ReadLine(); 
            Console.WriteLine("Ingrese color del vehículo");
            string color = Console.ReadLine();
            AgregarFilasUsuario(marca, color, tablaInventario);
            //Recorrer DataTable con Filtro usando Select
            DataRow[] filasAutos = tablaInventario.Select("Color like 'n%'");
            foreach(DataRow row in filasAutos)
            {
                Console.WriteLine($"Id: {row["CarID"]}, Marca: {row["Marca"]}, Color: {row["Color"]}");
            }
        }

        public static DataTable CrearTabla()
        {
            DataTable tablaInventario = new DataTable("Inventario");
            return tablaInventario;
        }
        public static void CrearColumnaID(DataTable dataTable)
        {
            DataColumn carIdColumna = new DataColumn("CarID", typeof(int));
            dataTable.Columns.Add(carIdColumna);
            carIdColumna.Caption = "ID Auto";
            carIdColumna.ReadOnly = true;
            carIdColumna.AllowDBNull = false;
            carIdColumna.Unique = true;
            carIdColumna.AutoIncrement = true;
            carIdColumna.AutoIncrementSeed = 0;
            carIdColumna.AutoIncrementStep = 1;
        }

        public static void CrearOtrasColumnas(DataTable dataTable)
        {
            DataColumn marcaAuto = new DataColumn("Marca", typeof(string));
            DataColumn colorAuto = new DataColumn("Color", typeof(string));
            dataTable.Columns.AddRange(new DataColumn[] { marcaAuto, colorAuto });
        }

        public static void AgregarFilas(DataTable dataTable)
        {
            DataRow filaAuto = dataTable.NewRow();
            filaAuto["Marca"] = "BMW";
            filaAuto["Color"] = "verde petroleo";
            dataTable.Rows.Add(filaAuto);
            filaAuto = dataTable.NewRow();
            filaAuto["Marca"] = "Renault";
            filaAuto["Color"] = "negro mate";
            dataTable.Rows.Add(filaAuto);
        }

        public static void AgregarFilasUsuario(string marca, string color, DataTable dataTable)
        {
            DataRow filaAuto = dataTable.NewRow();
            filaAuto["Marca"] = marca;
            filaAuto["Color"] = color;
            dataTable.Rows.Add(filaAuto);

        }
    }
}
