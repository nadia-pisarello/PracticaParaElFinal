using System;
using System.IO.Ports;

namespace PracticaParaElFinal
{
    internal class Array00
    {
        public static void MainFalso()
        {            
            int[] arr = { 1, 4, 5 };
            System.Console.WriteLine("En Main, antes de llamar al método ChangeForValue, primer elemento: {0}", arr[0]);
            Array00.ChangeForValue(arr);
            System.Console.WriteLine("En Main, después de llamar al método ChangeForValue y antes de ChangeForRef, primer elemento: {0}", arr[0]);
            System.Console.WriteLine("En Main, antes de llamar al método ChangeForRef. Arreglo: " + "{ " + string.Join(", ", arr) + " }");
            Array00.ChangeForRef(ref arr);
            System.Console.WriteLine("En Main, después de llamar al método ChangeForRef. Arreglo: " + "{ " + string.Join(", ", arr) + " }");
        }
        public static void ChangeForValue(int[] pArray)
        {
            pArray[0] = 888;
            pArray = new int[5] { -5, -1, -2, -3, -4 };
            System.Console.WriteLine("En ChangeForValue, primer elemento: {0}", pArray[0]);
            System.Console.WriteLine("En ChangeForValue. Arreglo: " + "{ "+string.Join(", ",pArray)+" }");
        }
        public static void ChangeForRef(ref int[] pArray)
        {
            pArray[0] = 888;
            pArray = new int[] { -2, -3, -4 };
            System.Console.WriteLine("En ChangeForRef. Arreglo: " + "{ "+string.Join(", ",pArray)+" }");
        }

    }
}