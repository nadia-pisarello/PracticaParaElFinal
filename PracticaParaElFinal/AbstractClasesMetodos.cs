using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class AbstractClasesMetodos
    {
        public static void MainFalso()
        {
            Cuadrado cuadrado = new Cuadrado(6);
            Console.WriteLine($"Area del cuadrado = {cuadrado.Area()}");
        }
        public abstract class ClaseAbstractaFiguras
        {
            protected int vertice; // los campos no pueden ser abstractos
            abstract public int Area();
            /* El método Superficie No puede estar sellado por que es una invalidación (abstract)
            abstract sealed protected double Superficie();
            */
            abstract public double Perimetro();
            // Una clase abstracta puede tener metodos de instancia.
           public virtual void Nombre() { } // puedo tener miembros no abstractos
        
        }

        /* Una clase no abstracta derivada de una clase abstracta debe incluir implementaciones
         * reales de todos los descriptores de acceso y métodos abstractos heredados.*/
        class Cuadrado : ClaseAbstractaFiguras
        {
            
            int lado = 0;
            public Cuadrado(int lado)
            {
                this.lado = lado;
            }
            public override int Area() 
            {
                return lado * lado;
            }
            // Nombre() puede no implementarse porque no es abstract y no debo si o si implementar
            public override double Perimetro()
            {
                return lado * 4;
            }
        }

    }
}
