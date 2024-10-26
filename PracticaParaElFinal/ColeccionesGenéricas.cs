using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class ColeccionesGenéricas
    {
        public static void MainFalso()
        {
            PersonaCollection personas = new PersonaCollection();
            personas.AddPersona(new Persona("Pepe", "Gomez", 58));
            personas.AddPersona(new Persona("Frank", "Super", 38));
            personas.AddPersona(new Persona("Nico", "Robin", 35));

            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (Persona p in personas)
            {
                Console.WriteLine(p.ToString());
            }
            sw.Stop();
            Console.WriteLine($"Tiempo de ejecucción foreach {sw.ElapsedTicks}");
            int ticks = 11770;
            int nanoseconds_per_tick = 100;
            var seconds = (ticks * nanoseconds_per_tick) / 1e9;
            Console.WriteLine(1e9);
            Console.WriteLine(seconds);
        }
    }

    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona() { }
        public Persona (string nombre, string apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}, {Edad} años de edad";
        }
    }

    class PersonaCollection : IEnumerable
    {
        // Utilizamos ArrayList, que permite agregar cualquier tipo de objeto
        private ArrayList personas = new ArrayList();

        // Método para agregar una Persona
        public void AddPersona(Persona persona)
        {
            personas.Add(persona);
        }

        // Implementamos GetEnumerator para poder recorrer la colección
        public IEnumerator GetEnumerator()
        {
            foreach (var persona in personas)
            {
                // El casting es necesario porque ArrayList puede contener cualquier tipo de objeto
                yield return (Persona)persona;
            }
        
        }
    }

}
