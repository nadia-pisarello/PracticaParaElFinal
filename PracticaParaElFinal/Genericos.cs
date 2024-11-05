using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class Genericos
    {
        public static void MainFalso()
        {
            UsarSortGenerico();
            IntercambiadorInt();
            IntercambiadorString();
        }    

        static void UsarSortGenerico()
        {
            int[] myInts = { 105, 4, 2, 33, 210 };
            //Ocupa el método genérico Sort
            Array.Sort<int>(myInts);
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        public class Intercambiador<T>
        {
            public void Ejecutar(ref T a, ref T b)
            {
                T temp;
                temp = a;
                a = b;
                b = temp;
            }
        }

        static void IntercambiadorInt()
        {
            Intercambiador<int> intercambiador = new Intercambiador<int>();
            int num1 = 5, num2 = 10;
            Console.WriteLine($"Antes del intercambio: num1 = {num1}, num2 = {num2}");
            intercambiador.Ejecutar(ref num1, ref num2);
            Console.WriteLine($"Después del intercambio: num1 = {num1}, num2 = {num2}");
        }

        static void IntercambiadorString()
        {
            Intercambiador<string> intercambiadorString = new Intercambiador<string>();
            string str1 = "Hola";
            string str2 = "Mundo";
            Console.WriteLine($"\nAntes del intercambio: str1 = {str1}, str2 = {str2}");
            // Intercambiar valores de tipo string
            intercambiadorString.Ejecutar(ref str1, ref str2);
            Console.WriteLine($"Después del intercambio: str1 = {str1}, str2 = {str2}");
        }

        public interface IComparable<T> // interfaz genérica
        {
            int CompareTo(T other);
        }

        public class Auto : IComparable<Auto> 
        {
            private int autoID;             
            public int AutoID { get => autoID; set => autoID = value; } 
            // IComparable<T> implementation
            int IComparable<Auto>.CompareTo(Auto obj)
            {
                if (this.AutoID > obj.AutoID) return 1;
                if(this.AutoID < obj.AutoID) return -1;
                else return 0;
            }
        }
    }
}
