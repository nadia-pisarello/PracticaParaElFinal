using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class ParametrosDeMetodos
    {
        internal static void MainFalso()
        {
            ParametrosDeMetodos instancia = new ParametrosDeMetodos();
            //instancia.LlamarPorValor();
            //instancia.ModificadorOut();
            //instancia.ModificadorRef();
            //instancia.ModificadorIn();
            instancia.ModificadorParams();
        }

        // Pasaje Por Valor
        void LlamarPorValor()
        {
            int x = 9; int y = 10;
            Console.WriteLine("Antes de la llamada: x {0}, y: {1}", x, y);
            Console.WriteLine("El resultado = {0}", SumarPorValor(x, y));
            Console.WriteLine("Después de la llamada: x: {0}, y: {1}", x, y);
        }
        int SumarPorValor(int x, int y)
        {
            int z = x + y;
            x = 100; y = 100;
            return z;
        }

        // Pasaje Por Referencia
        // Modificador out
        void ModificadorOut()
        {
            Console.WriteLine("Modificador out");

            int z = 0;
            Console.WriteLine("Antes de la llamada: z: {0}", z);
            SumarPorSalida(90, 90, out z);
            Console.WriteLine("Después de la llamada: z:{0}", z);
            void SumarPorSalida(int x, int y, out int o)
            {
                o = x + y;
                x = 100; y = 100;
            }
        }

        void ModificadorRef()
        {
            Console.WriteLine("Modificador ref");
            int x = 9, y = 5;
            Console.WriteLine("Antes de la llamada: x: {0}, y: {1}", x, y);
            SumarPorRef(ref x, ref y);
            Console.WriteLine("Después de la llamada: x: {0}, y: {1}", x, y);

            int SumarPorRef(ref int i, ref int j)
            {
                int k = i + j;
                i = 100; j = 100;
                return k;
            }
        }

        void ModificadorIn()
        {
            Console.WriteLine("Modificador in");
            int x = 8, y = 5;
            Console.WriteLine("Antes de la llamada: x: {0}, y: {1}", x, y);
            SumarPorEntrada(in x, in y);
            Console.WriteLine("Después de la llamada: x: {0}, y: {1}", x, y);

            int SumarPorEntrada(in int i, in int j){
                int z = i + j;
                // x = 1000 ; y = 1000;
                // si se intenta asignar x o y arroja un error, actúa como readonly
                return z;
            }
        }

        void ModificadorParams()
        {
            int x = 8, y = 5;
            Console.WriteLine("Antes de la llamada: x: {0}, y: {1}", x, y);
            double promedio = CalcularPromedio(x, y, 4, 50, 8, 10, 15, 84);
            Console.WriteLine("Después de la llamada: x: {0}, y: {1}, promedio: {2}", x, y, promedio);
            double CalcularPromedio( params int[] values)
            {
                Console.WriteLine("Me enviaste {0} valores", values.Length);
                double sum = 0;
                if (values.Length == 0){
                    return sum;
                }
                for (int i = 0; i < values.Length; i++)
                {
                    Console.Write(" {0}",values[i]);
                    sum += values[i];
                }
                Console.WriteLine();
                return(sum/values.Length);
            }
        }
    }
}
