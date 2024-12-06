using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class SerializacionBinaria
    {
        internal static void MainFalso()
        {
            List<Libro> libroList = new List<Libro>()
        {
            new Libro("Oda Ichiro", "One Piece Vol. 1", DateTime.Parse("1995-01-01")),
            new Libro("Ghibli", "Libro Mágico", DateTime.Parse("1990-05-05")),
            new Libro("Oda Ichiro", "One Piece Vol. 2", DateTime.Parse("1996-02-02")),
            new Libro("Roronoa", "Libro Mágico", DateTime.Parse("1982-08-08"))
        };

            string filePath = "libros.json";

            // Serializar directamente a JSON y guardar
            string jsonString = JsonConvert.SerializeObject(libroList, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Datos serializados en formato JSON.");

            // Leer y deserializar
            string fileContent = File.ReadAllText(filePath);
            List<Libro> deserializedList = JsonConvert.DeserializeObject<List<Libro>>(fileContent);
            Console.WriteLine("Datos deserializados:");
            foreach (var libro in deserializedList)
            {
                Console.WriteLine(libro.Describir());
            }
        }
    }

}

