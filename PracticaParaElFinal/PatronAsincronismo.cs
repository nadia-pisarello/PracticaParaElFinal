using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class PatronAsincronismo
    {
        public async static Task MainFalso()
        {
            Stopwatch sw = new Stopwatch();
            // Medir tiempo sincrónico
            sw.Start();
            ReadFileSync();
            sw.Stop();
            Console.WriteLine($"Sincrónico: {sw.ElapsedMilliseconds} ms\n");

            // Medir TAP
            sw.Start ();
            await ReadFileAsync();
            sw.Stop();
            Console.WriteLine($"TAP: {sw.ElapsedMilliseconds} ms\n");

            // Medir APM
            sw.Start();
            ReadAsyncAPM();
            sw.Stop();
            Console.WriteLine($"APM: {sw.ElapsedMilliseconds} ms\n");

            // Medir EAP
            sw.Start();
            ReadAsyncEAP();
            sw.Stop ();
            Console.WriteLine($"EAP: {sw.ElapsedMilliseconds} ms\n");
        }
        // Método Sincrónico
        public static void ReadFileSync()
        {
            using (FileStream fs = new FileStream("datos.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                int bytesRead = fs.Read(buffer, 0, buffer.Length);
                string text = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Sincrónico: " + text);
            }
        }

        //TAP Task-based Asynchronous Pattern
        public static async Task ReadFileAsync()
        {
            using (FileStream fs = new FileStream("datos.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                int bytesRead = await fs.ReadAsync(buffer,0, buffer.Length);
                string text = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("TAP (Task-based): " + text);
            }
        }
        //AMP
        public static void ReadAsyncAPM()
        {
            FileStream fs = new FileStream("datos.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(EndReadCallbackAPM), buffer);
        }

        public static void EndReadCallbackAPM(IAsyncResult asyncResult)
        {
            byte[] buffer = (byte[])asyncResult.AsyncState;
            string text = System.Text.Encoding.UTF8.GetString(buffer);
            Console.WriteLine("APM (Begin/End): " + text );
        }

        //EAP
        public static void ReadAsyncEAP()
        {
            FileStream fs = new FileStream("datos.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];

            IAsyncResult asyncResult = fs.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(EndReadCallbackEAP), buffer);
        }
        public static void EndReadCallbackEAP(IAsyncResult asyncResult)
        {
            byte[] buffer = (byte[])asyncResult.AsyncState;
            string text = System.Text.Encoding.UTF8.GetString(buffer);
            Console.WriteLine("EAP (Event-based): " + text);
        }
    }
}

/* El patrón APM y el patrón EAP están basados en mecanismos similares en términos de uso
 * del sistema, y aunque técnicamente realizan las mismas operaciones, su tiempo de
 * ejecución puede variar debido a factores del entorno del sistema operativo, como
 * el uso de la caché, la carga del sistema, y las condiciones generales de hardware
 * en ese momento. Los patrones de programación asincrónica no garantizan tiempos de
 * ejecución consistentes, ya que están sujetos a estas condiciones externas.
 */
