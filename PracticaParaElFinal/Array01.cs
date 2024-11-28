
using Microsoft.Win32.SafeHandles;
using System;

namespace PracticaParaElFinal
{
    internal class Array01
    {
        public static void MainFalso()
        {
            Array01 instancia = new Array01();
            //instancia.Ejemplo();
            instancia.InicializacionDeArreglosMultidimensionalJagged();

        }

        void Ejemplo()
        {
            int[,] array = new int[,] { }; // instanciando arreglo vacio de 2 dimensiones
            int[,] arr = new int[2, 3] { { 2, 3, 5 }, { 0, -1, -2 } }; // Crea un arreglo de dos dimensiones
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("Dimensión: {0}", i + 1);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("**************************************************");

            int longitudTotal = arr.Length; //Obtiene el número total de elementos ( 2 * 3 = 6)            
            Console.WriteLine("Longitud Total o total de Elementos: {0}\n", longitudTotal);
            int longitudDim1 = arr.GetLength(0);// Obtiene la longitud de la primera dimensión (2)
            Console.WriteLine("Longitud de la primera dimensión: {0}\n", longitudDim1);
            int longitudDim2 = arr.GetLength(1);// Obtiene la longitud de la segunda dimensión (3)
            Console.WriteLine("Longitud de la segunda dimensión: {0}\n", longitudDim2);
            Console.WriteLine("Longitud de la dimensión de un array vacio: {0}\n", array.Length);
        }

        void InicializacionDeArreglosUnidimensional()
        {
            // Inicialización en Línea de Arreglos 
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = new int[] { 1, 2, 3 };
            int[] arr3 = new int[3] { 1, 2, 3 };

            // Otra Forma
            int[] arr4 = new int[2];
            arr4[0] = 1;
            arr4[1] = 8;
        }

        void InicializacionDeArreglosMultidimensional()
        {
            int[,] arr0 = new int[,] { { 2, 3, 5 }, { 0, -1, -2 } };
            int[,] arr1 = new int[2, 3] { { 2, 3, 5 }, { 0, -1, -2 } };
            int[,] arr2 = { { 2, 3, 5 }, { 0, -1, -2 } };
        }

        void InicializacionDeArreglosMultidimensionalJagged()
        {
            int[][] arrDeArr = new int[5][];

            // Para crear
            for(int i = 0; i < arrDeArr.Length; i++)
            { 
                arrDeArr[i] = new int[i + 7]; 
            }

            // Para imprimir
            for ( int i = 0;i < 5; i++)
            {
                for (int j = 0; j < arrDeArr[i].Length; j++)
                {
                    Console.Write(arrDeArr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
