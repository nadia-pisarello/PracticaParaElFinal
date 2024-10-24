using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal interface IColeccionable
    {
        string Titulo { get; set; }
        string Describir();
    }
}
