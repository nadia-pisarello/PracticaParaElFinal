using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticaParaElFinal.StaticClasesMetodos;

namespace PracticaParaElFinal
{
    internal class StaticClasesMetodos
    {
        public static void MainFalso()
        {
            // Métodos estáticos pueden ser invocados sin crear una instancia  
            MiClase.MetodoEstatico();
            // Crear una instancia para invocar el método de instancia
            MiClase miClase = new MiClase();
            miClase.MétodoDeInstancia();

            MiClase mc1 = new MiClase();
            MiClase mc2 = new MiClase();
            MiClase mc3 = new MiClase();

            // El valor de ContadorGlobal es compartido entre todas las instancias
            Console.WriteLine($"Mostrando única copia de miembro estático: {MiClase.ContadorEstatico}"); // Imprime 3

            // Llamando método de instancia que muestra miembro estático
            mc1.MostrarValorEstatico();

            // Llamando método estático que muestra miembro de instancia
            MiClase.MostrarValorDeInstancia();

            // Uso del patrón Singleton
            MiClaseSingleton instancia = MiClaseSingleton.ObtenerInstancia();
            instancia.MostrarMensaje();
        }

        public class MiClase
        {
            public static int ValorEstatico = 28;
            public int valorDeInstancia = 5;
            public static int ContadorEstatico = 0;

            public MiClase()
            {
                ContadorEstatico++;
            }

            // los miembros de instancia de la clase pueden acceder a los miembros estáticos
            public void MostrarValorEstatico()
            {
                Console.WriteLine($"Valor Estatico {ValorEstatico}");
            }

            // Un miembro estático no puede acceder a los miembros de instancia de la clase
            public static void MostrarValorDeInstancia()
            {
                /* Esto da error 
                Console.WriteLine($"Valor de Instancia {valorDeInstancia}"); 
                Necesita una instancia*/
                MiClase miClase = new MiClase();
                Console.WriteLine($"Valor de Instancia: {miClase.valorDeInstancia}");
            }
            public static void MetodoEstatico()
            {
                Console.WriteLine("Llamada al Método Estático");
            }

            public void MétodoDeInstancia()
            {
                Console.WriteLine("Llamada al Método de Instancia");
            }
        }

        // El patrón Singleton asegura que solo exista una instancia de una clase,
        // controlada por un método estático.
        public class MiClaseSingleton
        {
            private static MiClaseSingleton unicaInstancia;
            public MiClaseSingleton() { }
            public static MiClaseSingleton ObtenerInstancia()
            {
                if (unicaInstancia == null)
                {
                    unicaInstancia = new MiClaseSingleton();
                }
                return unicaInstancia;
            }
            public void MostrarMensaje()
            {
                Console.WriteLine("El Patrón Singleton");
            }
        }

        // No se pueden crear instancias de una clase estática. 
        // Sólo contiene miembros estáticos, no puede tener miembros de instancia
        // Es de tipo Sealed. No se puede hacer una herencia.
        public static class ClaseEstatica
        {
            /* Estas lineas dan error
            private string nombre; 
            public string Nombre { get =>  nombre; set => nombre = value; }
            public void Imprimir()
            {
                Console.WriteLine("En la Clase Estática: Todos los miembros deben ser estáticos!");
            }
            */
            private static string nombre;
            public static string Nombre { get =>  nombre; set => nombre = value; }
            public static void Imprimir()
            {
                Console.WriteLine("En la Clase Estática: Todos los miembros deben ser estáticos!");
            }
        }
        /* Esto no se puede hacer. PruebaHerenciaClaseEstatica no puede derivar de ClaseEstatica
        public class PruebaHerenciaClaseEstatica: ClaseEstatica { }
        */

        // Una clase estática puede contener constructores estáticos, pero no de instancia
        public static class ClaseConConstructorEstatico
        {
            public static double DeCelsiusAFahrenheit(string temperaturaEnCelsius)
            {
                // Convierte el argumento a double pàra calcular
                double celsius = Double.Parse(temperaturaEnCelsius);
                // Convierte de celsius a fahrenheit
                double fahrenheit = (celsius * 9 / 5) + 32;
                return fahrenheit;
            }
        }

        // Constructores estáticos: Tienen que ver con funcionalidades matemáticas que son siempre
        // iguales independientemente de la instancia a la que se le pueda aplicar
    }
}
