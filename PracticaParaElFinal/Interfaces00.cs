using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class Interfaces00
    {
        public static void MainFalso()
        {
            // Implícita - Sólo se coloca el nombre del método, que debe ser el mismo que el de la interfaz
            // Se accede a través de la clase
            Hexagono hex = new Hexagono("Hexagono1");
            Console.WriteLine($"Vertices: {hex.Vertices}");

            // Explícita, se indica de qué intrerfaz se implementa.
            // Se acceden siempre a través de la interfaz
            IControl c = hex;
            c.Dibujar();
            ISuperficie s = hex;
            s.Dibujar();
            IVertice iv = hex as IVertice; 
            //'as' permite determinar dinámicamente si 'hex' implementa IVertice e intenta convertirlo si falla devolverá 'null'
            if (iv != null)
                Console.WriteLine($"Vértices: {iv.Vertices}");
            else Console.WriteLine("No tiene vertices");

            Figura[] misFiguras = { new Hexagono("Hex1"), new Hexagono("Hex2"), new Hexagono("Hex3") };
            for (int i = 0; i < misFiguras.Length; i++)
            {
                misFiguras[i].Dibujar();
                IVertice v = misFiguras[i] as IVertice;
                if (misFiguras[i] is IVertice) //'is' permite determinar dinámicamente si objeto implementa interfaz IVertice
                    Console.WriteLine($"-> Vértices: {v.Vertices}");
                else
                    Console.WriteLine($"-> {misFiguras[i].Nombre} no tiene vértices");
            }
        }
    }
}

namespace PracticaParaElFinal
{
    internal class Figura
    {
        private string nombre;
        private int lados;
        private int perimetro;
        private int area;

        public Figura(string nombre) 
        {
            this.Nombre = nombre;
        }
        public Figura(string nombre, int lados, int perimetro, int area)
        {
            this.Nombre = nombre;
            this.Lados = lados;
            this.Perimetro = perimetro;
            this.Area = area;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Lados { get => lados; set => lados = value; }
        public int Perimetro { get => perimetro; set => perimetro = value; }
        public int Area { get => area; set => area = value; }

        public virtual void Dibujar() // Método virtual
        {
            Console.WriteLine("Dibuja una figura genérica");
        }
    }

    // Herencia: primero se llaman a las clases luego a las interfaces
    internal class Hexagono : Figura, IVertice, IControl, ISuperficie
    {
        public Hexagono(string nombre) : base(nombre) { }
        public Hexagono(string nombre, int lados, int perimetro, int area) : base(nombre, lados, perimetro, area) { }
        
        public byte Vertices //Implementación implícita 
        {
            get { return 6; }
        }

        void IControl.Dibujar() //Implementación explícita, debo decir de que interfaz proviene
        {
            Console.WriteLine("IControl.Dibujar"); 
        }
        void ISuperficie.Dibujar() //Implementación explícita
        {
            Console.WriteLine("ISuperficie.Dibujar");
        }
        public override void Dibujar()
        {
            Console.WriteLine($"Dibuja hexágono {Nombre} (método invalidado");
        }
        public bool EsPar() {  return true; }
    }

    public interface IVertice
    {
        byte Vertices{ get; }
        bool EsPar();
    }

    public interface IControl
    {
        void Dibujar();
    }
    public interface ISuperficie
    {
        void Dibujar();
    }
}
