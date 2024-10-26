using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class Moda
    {
        public static void MainFalso (){
            int[] arr = { 1, 1, 1, 2, 3, 3, 4, 5, 6 };
            int[] arr2 = { 1, 1, 1, 2, 3, 3, 3, 3, 4, 5, 6 };
            ModaBucle(arr2);
            ModaDictionary(arr2);
        }
        //params permite ingresar una cantidad de valores indeterminados
        public static void ModaBucle(params int[] arr)
        {
            int moda = 0;
            int rep = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int con = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        con++;
                    }
                }

                if (con > rep)
                {
                    moda = arr[i];
                    rep = con;
                }
            }
            Console.WriteLine("La moda de la lista es: {0}", moda);
        }

        public static void ModaDictionary(params int[] arr)
        {
            Dictionary<int, int > frecuencia = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                //ContainsKey sirve para verificar si una clave especifica existe en el diccionario. Retorna un bool true si existe
                if (frecuencia.ContainsKey(i))
                {
                    //estoy colocando como key al valor que está en i
                    frecuencia[i]++;
                }
                else
                {
                    frecuencia[i] = 1;
                }
            }
            int moda = 0;
            int rep = 0;
            foreach (var i in frecuencia) { 
                if(i.Value > rep)
                {
                    moda = i.Key;
                    rep = i.Value;
                }
            }
            Console.WriteLine("La moda de la lista con diccionario es: {0}", moda);
        }
    }
}
