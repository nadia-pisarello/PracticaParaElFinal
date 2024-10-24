using System;
using System.Data;
using System.Data.Common;

namespace PracticaParaElFinal
{
    internal class EjercicioDataSetNoTipado
    {
        public static void MainFalso()
        {
            DataTable[] dt = CrearTablas();
            DataSet inventarioDeAutos = CrearDataSet(dt);
            AgregarDataRelations(dt, inventarioDeAutos);
            foreach(DataRow drPadre in dt[0].Rows) // Tabla Cliente
            {
                Console.WriteLine("Id Cliente: " + drPadre["ClienteID"] + " Nombre: " + drPadre["Nombre"]);
                // Obtener las filas relacionadas (autos comprados por el cliente actual)
                DataRow[] autosRelacionados = drPadre.GetChildRows("Comprar");
                foreach (DataRow drHijo in autosRelacionados) // Tabla Inventario
                {
                    Console.WriteLine("\tId Cliente: " + drHijo["ClienteIDFK"] + " Marca: " + drHijo["Marca"] + " Color: " + drHijo["Color"]);
                    
                }
            }

        }

        static DataTable[] CrearTablas()
        {
            DataTable[] dt;
            DataTable tablaInventario = EjercicioDataTable.CrearTabla();
            EjercicioDataTable.CrearColumnaID(tablaInventario);
            EjercicioDataTable.CrearOtrasColumnas(tablaInventario);
            EjercicioDataTable.AgregarFilas(tablaInventario);
            DataColumn clienteIdFK = new DataColumn("ClienteIDFK", typeof(int));
            tablaInventario.Columns.Add(clienteIdFK);
            DataTable tablaCliente = new DataTable("Cliente");
            CrearColumnaID(tablaCliente);
            CrearOtrasColumnas(tablaCliente);
            AgregarFilasCliente(tablaCliente);
            dt = new DataTable[] { tablaCliente, tablaInventario };
            return dt;
        }

        static DataSet CrearDataSet(DataTable[] dataTables)
        {           
            DataSet carInventoryDS = new DataSet("Inventario de Automóviles");
            carInventoryDS.Tables.Add(dataTables[0]);
            carInventoryDS.Tables.Add(dataTables[1]);
            return carInventoryDS;
        }

        static void CrearColumnaID(DataTable dataTable)
        {
            DataColumn clienteIdColumna = new DataColumn("ClienteID", typeof(int));
            dataTable.Columns.Add(clienteIdColumna);
            clienteIdColumna.Caption = "ID Cliente";
            clienteIdColumna.ReadOnly = true;
            clienteIdColumna.AllowDBNull = false;
            clienteIdColumna.Unique = true;
            clienteIdColumna.AutoIncrement = true;
            clienteIdColumna.AutoIncrementSeed = 0;
            clienteIdColumna.AutoIncrementStep = 1;
        }

        static void CrearOtrasColumnas(DataTable dataTable)
        {
            DataColumn nombre = new DataColumn("Nombre", typeof(string));
            DataColumn celular = new DataColumn("Celular", typeof(string));
            dataTable.Columns.AddRange(new DataColumn[] { nombre, celular });

        }

        static void AgregarFilasCliente(DataTable tablaCliente)
        {
            DataRow filaCliente1 = tablaCliente.NewRow();
            filaCliente1["Nombre"] = "Robin";
            filaCliente1["Celular"] = "123456789";
            tablaCliente.Rows.Add(filaCliente1);

            DataRow filaCliente2 = tablaCliente.NewRow();
            filaCliente2["Nombre"] = "Nami";
            filaCliente2["Celular"] = "987654321";
            tablaCliente.Rows.Add(filaCliente2);
        }

        static void AgregarDataRelations(DataTable[] dataTables, DataSet dataSet)
        {
            DataRelation relation = new DataRelation("Comprar", dataTables[0].Columns["ClienteID"], dataTables[1].Columns["ClienteIDFK"], true);
            dataSet.Relations.Add(relation);
            dataTables[1].Rows[0]["ClienteIDFK"] = 0;
            dataTables[1].Rows[1]["ClienteIDFK"] = 1;
        }
    }
}


