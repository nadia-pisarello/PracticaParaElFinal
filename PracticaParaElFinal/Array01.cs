
using Microsoft.Win32.SafeHandles;
using System;

namespace PracticaParaElFinal
{
    internal class Array01
    {
        public static void MainFalso()
        {
            int[,] arr = new int[2, 3] { { 2, 3, 5 } , { 0, -1, -2 } }; // Crea un arreglo de dos dimensiones
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("Dimensión: {0}", i+1);
                for(int j= 0 ; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
            int longitudTotal = arr.Length; //Obtiene el número total de elementos ( 2* 3 = 6)
            
            Console.WriteLine("Longitud Total o total de Elementos: {0}", longitudTotal); 
            int longitudDim1 = arr.GetLength(0);// Obtiene la longitud de la primera dimensión (2)
            Console.WriteLine("Longitud de la primera dimensión: {0}", longitudDim1); 
            int longitudDim2 = arr.GetLength(1);// Obtiene la longitud de la segunda dimensión (3)
            Console.WriteLine("Longitud de la segunda dimensión: {0}", longitudDim2); 
            
        }
    }
}
