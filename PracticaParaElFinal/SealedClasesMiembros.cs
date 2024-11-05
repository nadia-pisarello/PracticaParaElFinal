using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class SealedClasesMiembros
    {
        public static void MainFalso()
        {
            Clase1 clase1 = new Clase1();
            clase1.Metodo1();
            Clase2 clase2 = new Clase2();
            clase2.Metodo1();
            Clase3 clase3 = new Clase3();
            clase3.Metodo1();
        }
    }
    public sealed class ClaseSellada
    {
        private string nombre;
        public ClaseSellada() { }
        
    }

    public class Clase1
    {       
        public virtual void Metodo1()
        {
            Console.WriteLine("Metodo1 de Clase1");
        }
    }

    public class Clase2 : Clase1
    {
        sealed override public void Metodo1()
        {
            Console.WriteLine($"Metodo1 de {this}");
        }
    }

    public class Clase3 : Clase2
    {
        /* Esto da error - No se puede invalid/sobreescribir un metodo sellado
         * protected override void Metodo1() { Console.WriteLine(); }
         */
        
    }

    /* Esto no se puede hacer. PruebaClaseSellada no puede derivar de ClaseSellada
    public class PruebaHerenciaClaseSellada: ClaseSellada { }
    */
}
