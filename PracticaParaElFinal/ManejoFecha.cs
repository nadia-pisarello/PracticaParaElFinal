using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class ManejoFecha
    {
        public static void MainFalso()
        {
            DateTime fechaA, fechaB;
            Console.WriteLine("Ingrese fecha de inicio. Formato dd/mm/aaaa.\n");
            if (!DateTime.TryParse(Console.ReadLine(), out fechaA))
            {
                Console.WriteLine("No ingreso un formato de fecha válido.\n"); return;
            }
            Console.WriteLine("Ingrese fecha de fin. Formato dd/mm/aaaa\n");
            if (!DateTime.TryParse(Console.ReadLine(), out fechaB))
            {
                Console.WriteLine("No ingreso un formato de fecha válido.\n"); return;
            }
            ObtenerDiasCalendario(fechaA, fechaB);
            ObtenerDiasLaborables(fechaA, fechaB);
            SumarDiasLaborables(fechaA);
            
        }


        static void ObtenerDiasCalendario(DateTime a, DateTime b)
        {
        

            TimeSpan dias = new TimeSpan(0);
            if (a <= b)
            {
                dias = b - a;
                Console.WriteLine("Cantidad de dias calendario entre {0} y {1} es {2}.\n", a.ToShortDateString(), b.ToShortDateString(), dias.TotalDays);
            }
            else
            {
                Console.WriteLine("La fecha de inicio debe ser menor o igual a la fecha de fin.\n"); return;
            }
        }

        static void ObtenerDiasLaborables(DateTime a, DateTime b)
        {
            DateTime c = a;
            DateTime[] feriados = Feriados();
            int con = 0;
            while (c < b)
            {
                c = c.AddDays(1);
                if(c.DayOfWeek != DayOfWeek.Saturday && c.DayOfWeek != DayOfWeek.Sunday) 
                {
                    if (!feriados.Contains(c))
                    {
                        con++;
                    }
                }
            }
            Console.WriteLine("Cantidad de dias laborables entre {0} y {1} es de: {2}\n", a.ToShortDateString(), b.ToShortDateString(), con);
                
        }

        static void SumarDiasLaborables(DateTime fecha)
        {
            DateTime newFecha;
            DateTime[] feriados = Feriados();
            Console.WriteLine("Ingrese cantidad de dias que desea adicionar a la fecha de inicio.\n");
            if (Int32.TryParse(Console.ReadLine(), out var dias)){
                int con = 0;
                newFecha = fecha;
                while (con < dias) 
                {
                    newFecha = newFecha.AddDays(1);
                    if (newFecha.DayOfWeek != DayOfWeek.Sunday && newFecha.DayOfWeek != DayOfWeek.Saturday)
                    {
                        if (!feriados.Contains(newFecha))
                        {                            
                            con++;
                        }
                        else
                        {
                            Console.WriteLine("La fecha {0} es feriado", newFecha.ToShortDateString());
                        }

                    }                      
                    
                }

                Console.WriteLine("Fecha obtenida {0}.\n", newFecha.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Formato ingresado incorrecto\n"); return;
            }
        }

        static DateTime[] Feriados()
        {
            DateTime[] feriados = new DateTime[12];

            // Asignar una fecha diferente para cada mes
            feriados[0] = new DateTime(2024, 1, 15);   // Enero 15
            feriados[1] = new DateTime(2024, 2, 20);   // Febrero 20
            feriados[2] = new DateTime(2024, 3, 10);   // Marzo 10
            feriados[3] = new DateTime(2024, 4, 25);   // Abril 25
            feriados[4] = new DateTime(2024, 5, 5);    // Mayo 5
            feriados[5] = new DateTime(2024, 6, 18);   // Junio 18
            feriados[6] = new DateTime(2024, 7, 22);   // Julio 22
            feriados[7] = new DateTime(2024, 8, 8);    // Agosto 8
            feriados[8] = new DateTime(2024, 9, 12);   // Septiembre 12
            feriados[9] = new DateTime(2024, 10, 31);  // Octubre 31
            feriados[10] = new DateTime(2024, 11, 16); // Noviembre 16
            feriados[11] = new DateTime(2024, 12, 24); // Diciembre 24
            return feriados;
        }

    }
}
