using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class LINQ00
    {
        public static void MainFalso()
        {
            Empleado[] empleados = {
                new Empleado() { DNI = 1, Nombre = "Carlitos", Fecha_nacimiento = DateTime.Parse("1978/11/12") },
                new Empleado() { DNI = 2, Nombre = "Dana", Fecha_nacimiento = DateTime.Parse("1980/11/12") },
                new Empleado() { DNI = 3, Nombre = "Nero", Fecha_nacimiento = DateTime.Parse("1980/11/12") },
                new Empleado() { DNI = 4, Nombre = "Kala", Fecha_nacimiento = DateTime.Parse("1981/11/12") },
                new Empleado() { DNI = 5, Nombre = "Cora", Fecha_nacimiento = DateTime.Parse("1982/11/12") }
            };

            IEnumerable<(string, string, int)> query = from e in empleados
                                                  orderby e.Nombre descending
                                                  select (e.Nombre, e.Fecha_nacimiento.ToString("dd/MM/yyyy"), e.Edad);

            foreach ((string nombre, string fecha_nac, int edad) in query)
            {
                Console.WriteLine($"Empleado {nombre}, Fecha de nacimiento: {fecha_nac}, Edad: {edad}");
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~    Sintaxis Consulta Query    ~~~~~~~~~~~~~~~~~~~~~\n");
            var result = from e in empleados
                         where e.Edad > 40
                         select e;
            foreach ( var e in result)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(System.Environment.NewLine);

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~    Sintaxis Método Fluent     ~~~~~~~~~~~~~~~~~~~~~\n");
            var result2 = empleados.Where(e => e.Edad > 40);
            foreach ( var e in result2)
            {
                Console.WriteLine(e.ToString());    
            }

            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            Console.WriteLine(System.Environment.NewLine);

            //Query syntax:
            IEnumerable<int> numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num descending
                select num;

            //Method syntax:
            IEnumerable<int> numQuery2 = numbers.Where(num => num % 2 == 0).OrderBy(n => n);
            IEnumerable<int> numQuery3 = numbers.Where(num => num % 3 == 0).OrderByDescending(n => n);

            foreach (int i in numQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(System.Environment.NewLine);
            foreach (int i in numQuery2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(System.Environment.NewLine);

            foreach (int i in numQuery3)
            {
                Console.Write(i + " ");
            }

        }

        private class Empleado
        {
            int dni;
            string nombre;
            DateTime fecha_nacimiento;
            int edad; 

            public int DNI { get => dni; set => dni = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
            public int Edad { get => CalcularEdad(); }

            public int CalcularEdad()
            {
                DateTime fecha_actual = DateTime.Now;
                int edad = DateTime.Now.Year - Fecha_nacimiento.Year;
                if (fecha_actual < Fecha_nacimiento.AddYears(edad)){
                    edad--;
                }
                return edad;
            }
            public override string ToString()
            {
                return $"Empleado: {Nombre}, DNI: {DNI}, Edad: {Edad}, Fecha de Nacimiento: {Fecha_nacimiento.ToShortDateString()}";
            }
        }
    }
}
