using Newtonsoft.Json; // para utilizar este paquete se tuvo que instalar desde NuGet
using System;
using SerialJsonIgnore = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace PracticaParaElFinal
{
    public class Libro: IColeccionable, IComparable<Libro>
    {
        string autor;
        string titulo;
        DateTime fechEdicion;
        public Libro() { }
        public Libro(string autor, string titulo, DateTime fechEdicion) 
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.FechEdicion = fechEdicion;
        }
        public Libro(string autor, string titulo)
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.FechEdicion = fechEdicion;
        }

        public string Autor { get => autor ; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime FechEdicion {  get => fechEdicion; set => fechEdicion = value; }
        [JsonIgnore] // Ignoramos la antiguedad para serailizar porque es un dato derivado de otro
        [SerialJsonIgnore]
        public int Antiguedad => (DateTime.Now - fechEdicion).Days / 365; // se calcula dinámicamente
        public string Describir()
        {
            return ($"{this.Autor} - {this.Titulo} - Fecha de Edición {this.FechEdicion.ToShortDateString()} - Antigüedad: {this.Antiguedad} años");
        }
        public int CompareTo(Libro other)
        {
            int autor = this.Autor.CompareTo(other.Autor);
            if (autor == 0)
            {
                return this.Titulo.CompareTo(other.Titulo); ;
            }
             return autor;
        }
        /* Invalidación de métodos de Object */
        public override bool Equals(object other)
        {
            if (other == null || !(other is Libro)) return false;
            Libro libro = other as Libro;
            return libro.Describir() == this.Describir();
        }
        public override string ToString()
        {
            return ($"{this.Autor} - {this.Titulo} ");
        }
        public override int GetHashCode()
        {
            //int code = ((this.Autor !=null ? this.Autor.GetHashCode() : 0) + (this.Titulo != null ? this.Titulo.GetHashCode() : 0)) * 5;                    
            //return code;

            return this.Describir().GetHashCode();
        }



    }
}
