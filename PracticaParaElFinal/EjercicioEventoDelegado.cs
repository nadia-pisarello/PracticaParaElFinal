using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Notificar(); //Declaración del tipo delegado
namespace PracticaParaElFinal
{
    // event + delegate
    internal class EjercicioEventoDelegado // Clase Suscriptora
    {
        public static void MainFalso()
        { /* cuando el publicador dispara el evento lo que hace es ejecutar el EventHandler,
           * que en este caso es c_ThresholdReached”*/

            Contador c = new Contador(5);
            c.LimiteAlcanzado += c_LimiteAlcanzado; //Suscripción al evento
            Console.WriteLine("presione a para incrementar el total");
            while(Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("Adicionando 1: " + c.Total);
                c.Add(1);
            }
            Console.ReadKey();

        }
        static void c_LimiteAlcanzado() // Manejador del evento - define la acción que se ejecutará cuando 
        {                               // se dispare el evento LimiteAlcanzado
            Console.WriteLine("Se alcanzó el límite");
            Environment.Exit(0);
        }
        class Contador // Clase publicadora
                       // el suscriptor será la clase EjercicioEvento dentro del MainFalso
                       // donde se tiene una instancia del publicador y que se suscribe al evento
        {
            public event Notificar LimiteAlcanzado; //Declaración del evento del tipo delegado Notificar
            private int limite;                     // se dispara cuando el contador supera el limite definido
            private int total;                  //representado por la propiedad total

            public int Total { get => total; set => total = value; }

            public Contador(int limiteSuperado)
            {
                limite = limiteSuperado;
            }
            public void Add(int x)
            {
                Total += x;
                if (Total >= limite)            // si el total supera el limite 
                    LimiteAlcanzado?.Invoke();  // se invoca/se dispara el evento LimiteAlcanzado
               // '?' asegura que el evento solo se dispara si tiene algún suscriptor (si no es null)
            }
        }       
    }
}

/* Flujo de ejecución:
   1 - Se crea un objeto de la clase Contador con un límite de 3.
   2 - La clase EjercicioEvento se suscribe al evento LimiteAlcanzado del objeto Contador.
   3 - Mientras el usuario presiona la tecla 'a', se incrementa el valor de Total en Contador.
   4 - Cuando Total alcanza o supera el valor del límite, se dispara el evento LimiteAlcanzado, y
       como la clase EjercicioEvento está suscrita al evento, se ejecuta el método c_LimiteAlcanzado.
   5 - De esta forma, la clase Contador (publicadora) notifica a EjercicioEvento (suscriptora) cuando
       se cumple la condición establecida (límite alcanzado).
*/
