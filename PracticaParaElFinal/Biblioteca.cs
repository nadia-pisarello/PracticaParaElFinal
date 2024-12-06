using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class Biblioteca
    {
        public static void MainFalso()
        {
            Libro libro1 = new Libro("Oda Ichiro", "One Piece Vol. 1");
            Libro libro2 = new Libro("Ghibli", "Libro Mágico");
            Libro libro3 = new Libro("Oda Ichiro", "One Piece Vol. 2");
            Libro libro4 = new Libro("Roronoa", "Libro Mágico");
            Libro[] biblioteca = { libro1, libro2, libro3, libro4 };
            foreach (Libro b in biblioteca)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("\n================================== \n");
            string verifica = biblioteca[0].Equals(biblioteca[3]) ? "Sí" : "No";
            Console.WriteLine("Verificando si {0} y el {1} son el mismo libro de la biblioteca: {2}", libro1, libro3, verifica);
            Console.WriteLine("\n================================== \n");
            Console.WriteLine("El código hash de {0} es {1}", libro1, libro1.GetHashCode());
            Console.WriteLine("\n================================== \n");
            //Para realizar el Sort utiliza el metodo CompareTo de la clase Libro
            Array.Sort(biblioteca);
            foreach (Libro b in biblioteca)
            {
                Console.WriteLine(b.Describir());
            }
            Console.WriteLine("\n================================== \n");
            Console.WriteLine("libro1 es igual a libro2? {0}",Equals(libro1, libro2 ));
            Libro libro5 = new Libro("Oda Ichiro", "One Piece Vol. 1");
            Console.WriteLine("libro1 es igual a libro5? {0}", ReferenceEquals(libro1, libro5));
            libro5 = libro1;
            Console.WriteLine("libro1 es igual a libro5? {0}", ReferenceEquals(libro1, libro5));

        }
    }
}

/*
    1. IColeccionable (Interfaz): Es una interfaz que define un contrato que las clases deben seguir si la implementan.
            Propiedades: 
                Título: Esta es una propiedad que deben implementar las clases que hereden de esta interfaz.
            Métodos:
                Describir(): Un método que debe ser implementado para describir el objeto.
    2. IComparable (Interfaz): También es una interfaz, pero su propósito es permitir la comparación entre objetos,
       especialmente útil para ordenar. Las clases que implementen esta interfaz deben definir cómo se comparan entre sí.
    3. Libro (Clase): Esta clase implementa las interfaces IColeccionable e IComparable, por lo que está obligada
       a implementar las propiedades y métodos de ambas.
            Campos (atributos de la clase):
                 autor: Un campo que almacena el autor del libro.
                 titulo: Un campo que almacena el título del libro.
            Propiedades:
                 Autor: Propiedad que permite acceder y modificar el campo autor.
                 Titulo: Propiedad que permite acceder y modificar el campo titulo.
            Métodos:
                 CompareTo(): Método que se implementa al heredar de IComparable para comparar libros entre sí
                             (probablemente en función del título o del autor).
                 Describir(): Método que describe el libro (probablemente devuelve información como el título y el autor).
                 Libro: Esto parece hacer referencia al constructor de la clase Libro.
    4. Program (Clase):
        Es la clase principal donde se encuentra el método MainFalso, que es el punto de entrada de la aplicación.
        El método MainFalso ejecutará el código, como crear instancias de Libro, almacenarlas en una colección y ordenarlas.
------------------------------------------------------------------------------------------------------------------------------------
    *** Ejercicio que debes realizar ***
    a - Crear la interfaz IColeccionable con las propiedades y métodos especificados.
    b - Implementar la interfaz en la clase Libro, junto con la interfaz IComparable para permitir la comparación y ordenación.
    c - Almacenar objetos de tipo Libro en un arreglo llamado biblioteca.
    d - Ordenar el arreglo y mostrar los resultados.
 
*/
