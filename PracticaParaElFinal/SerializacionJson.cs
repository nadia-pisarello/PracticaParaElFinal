using Newtonsoft.Json; //para utilizar este paquete se tuvo que instalar desde NuGet
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer; //para utilizar este paquete se tuvo que instalar desde NuGet

namespace PracticaParaElFinal
{
    internal class SerializacionJson
    {
        public static void MainFalso()
        {
            Libro libro1 = new Libro()
            {
                Autor = "Eichiro Oda",
                Titulo = "Saga East BLue",
                FechEdicion = DateTime.Parse("1997-01-01")
            };
            // JsonSerializerOptions y JsonSerializer son del System.Text.Json
            var options = new JsonSerializerOptions { WriteIndented = true};
            string jsonStringAntiguedad = JsonSerializer.Serialize(libro1, options);
            Console.WriteLine("\nSerialización con System.Text sin Ignorar Antiguedad\n{0}", jsonStringAntiguedad);
            
            // JsonConver es del Newton.Json; En este caso no se muestra la Antiguedad
            string jsonString = JsonConvert.SerializeObject(libro1, Formatting.Indented);
            Console.WriteLine("Serialización con Newton Soft Ignorando Antiguedad\n" + jsonString);

            // Deserialización de libro1 Con System.Text
            
            Libro libro2 = JsonSerializer.Deserialize<Libro>(jsonStringAntiguedad);
            Console.WriteLine("\nDeserialización con System.Text: \t" + libro2);
            Libro libro3 = JsonConvert.DeserializeObject<Libro>(jsonString);
            Console.WriteLine("\nDeserialización con Newton Soft: \t" + libro3);

        }
        public static void MainFalso2()
        {
            List<Libro> libroList = new List<Libro>()
            {
                new Libro("Oda Ichiro", "One Piece Vol. 1", DateTime.Parse("1995-01-01")),
                new Libro("Ghibli", "Libro Mágico", DateTime.Parse("1990-05-05")),
                new Libro("Oda Ichiro", "One Piece Vol. 2", DateTime.Parse("1996-02-02")),
                new Libro("Roronoa", "Libro Mágico", DateTime.Parse("1982-08-08"))
            };

            string jsonStr = JsonConvert.SerializeObject(libroList, Formatting.Indented);            
            File.WriteAllText("Libros.json", jsonStr); // método estático para volcar un string a un archivo
            Console.WriteLine("\nDeserialización del Json\n");
            Deserializar();
        }

        private static void Deserializar()
        {
            string jsonString = File.ReadAllText("Libros.json"); // método estático para leer todo un archivo
            var listFromFile = JsonConvert.DeserializeObject<List<Libro>>(jsonString);
            foreach ( var item in listFromFile )
            {
                Console.WriteLine(item.Describir());
            }
        }

    }
}
