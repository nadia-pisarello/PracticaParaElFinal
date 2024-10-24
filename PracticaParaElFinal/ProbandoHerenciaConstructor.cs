using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class ProbandoHerenciaConstructor
    {
        public static void MainFalso()
        {
            new BaseClass();
            new DerivedClass();
            new BaseClass2();
            Console.WriteLine(new DerivedClass2());
        }

        class BaseClass
        {
            public BaseClass()
            {
                Console.WriteLine("Constructor de BaseClass invocado");
            }

            public virtual string Propiedad { get; set; }
        }

        class DerivedClass : BaseClass
        {
            public DerivedClass() : base() // Llama al constructor de BaseClass
            {
                Console.WriteLine("Constructor de DerivedClass invocado");
            }

            public override string Propiedad { get => base.Propiedad; set => base.Propiedad = value.ToUpper(); }
        }

        class BaseClass2 { }

        class DerivedClass2 : BaseClass2
        {
            // No hay constructores en BaseClass ni en DerivedClass
            // El constructor de Object se invocará implícitamente
        }
    }
}

/*
Explicando la cuarta salida: `PracticaParaElFinal.ProbandoHerenciaConstructor+DerivedClass2`.
Esta salida corresponde al resultado de `Console.WriteLine(new DerivedClass2());`.
Lo que sucede es:

1. **Instanciación de `DerivedClass2`:** Cuando llamas a `new DerivedClass2()`, se crea una instancia de `DerivedClass2`.
Aunque no has definido un constructor en `DerivedClass2`, el constructor predeterminado del compilador se invoca, el cual
a su vez invoca el constructor predeterminado de `BaseClass2`, y este último constructor no realiza ninguna acción visible.

2. **Impresión en consola con `Console.WriteLine`:** Al intentar imprimir una instancia de `DerivedClass2` usando
`Console.WriteLine`, el sistema llama al método `ToString()` de la instancia.

3. **Método `ToString()`:** En C#, la clase base de todas las clases (`Object`) proporciona una implementación
predeterminada del método `ToString()`. Esta implementación devuelve el nombre completo de la clase junto con el
nombre completo del espacio de nombres, así como un identificador único del objeto en memoria (hash code), si no
se ha sobrescrito el método `ToString()` en la clase derivada.

Dado que no has sobrescrito `ToString()` en `DerivedClass2`, se utiliza la implementación de `Object`. La salida
`PracticaParaElFinal.ProbandoHerenciaConstructor+DerivedClass2` es el resultado de `ToString()` mostrando el nombre
completo del tipo de la instancia (`DerivedClass2`) junto con el nombre del espacio de nombres y la clase que lo
contiene (`ProbandoHerenciaConstructor`).

En resumen, la salida que ves es el resultado de la llamada al método `ToString()` para la instancia de 
`DerivedClass2`, que muestra el nombre completo del tipo de objeto y su contexto en el espacio de nombres.

 */
