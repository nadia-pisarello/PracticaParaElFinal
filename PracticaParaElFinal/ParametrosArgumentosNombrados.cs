using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class ParametrosArgumentosNombrados
    {
        protected internal static void MainFalso()
        {
            ParametrosArgumentosNombrados instancia = new ParametrosArgumentosNombrados();
            instancia.MetodoDeEjemplo(1, opcionalStr: "cadena opcional");
            instancia.MetodoDeEjemplo(2, numeroOpcional: 20);
            instancia.MetodoDeEjemplo(3, "string por defecto", 30);
            instancia.MetodoDeEjemplo(4, numeroOpcional: 40, opcionalStr: "cadena opcional");
            instancia.MetodoDeEjemplo(5);


        }

        public void MetodoDeEjemplo(int requerido, string opcionalStr = "string por defecto", int numeroOpcional = 10)
        {
            Console.WriteLine("{0}: {1}, {2}", requerido, opcionalStr, numeroOpcional);
        }
    }
}
