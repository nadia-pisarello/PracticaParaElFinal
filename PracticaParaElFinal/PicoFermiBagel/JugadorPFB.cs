using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal.PicoFermiBagel
{
    internal class JugadorPFB
    {
        string nombre;
        string puntaje;
        string tiempo;

        public  JugadorPFB() { }
        public JugadorPFB(string nombre, string puntaje, string tiempo)
        {
            Nombre = nombre;
            Puntaje = puntaje;
            Tiempo = tiempo;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Puntaje { get { return puntaje; } set { puntaje = value; } }  
        public string Tiempo { get { return tiempo; } set { tiempo = value; } }

        public override string ToString()
        {
            return $"Nombre {Nombre} - Puntaje {Puntaje} - Tiempo: {Tiempo}";
        }

    }
}
