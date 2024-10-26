using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParaElFinal
{
    internal class Archivos
    {        
        public static void MainFalso()
        {
            FileInfo f = new FileInfo(@"Test.dat");
            FileInfo f2 = new FileInfo(@"Test2.dat");
            //FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.Read);
            //fs.Close();
            //AccederNavegarConDirectoryInfo();
            //AccederNavegarConDirectoryInfoYFile();
            //AccederNavegarConFileInfo(f, f2); // método que llama al método LeerEscribirConFileStream
            //LeerConFileStream(fs);
            //AccederNavegarMoverConDirectory();
            CopiarArchivo(f);

        }

        static void AccederNavegarMoverConDirectory() // puedo retornar un array de strings
        {
            string directorioActual = @"C:\Users\pisar\source\repos\PracticaParaElFinal\PracticaParaElFinal\bin\Debug";
            string archivo = @"C:\Users\pisar\OneDrive\Documentos\TUP\3er Cuatrimestre\PRO III\DestinoPracticaParaElFinal";
            try
            {
                var textFiles = Directory.EnumerateFiles(directorioActual, "*.txt");
                foreach (string archivoActual in textFiles)
                {
                    string fileName = archivoActual.Substring(directorioActual.Length + 1);
                    Directory.Move(archivoActual, Path.Combine(archivo, fileName));
                }
                Console.WriteLine("Se han movido todos los archivos al nuevo destino");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void AccederNavegarConDirectoryInfo() // puedo retornar una colección o arreglo de FileInfo
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Windows\system32");
            Console.WriteLine("***** Directorio *****");
            Console.WriteLine($"FullName: {dirInfo.FullName}");
            Console.WriteLine($"Name: {dirInfo.Name}");
            Console.WriteLine($"Parent: {dirInfo.Parent}");
            Console.WriteLine($"Creation: {dirInfo.CreationTime}");
            Console.WriteLine($"Attributes: {dirInfo.Attributes}");
            Console.WriteLine($"Root: {dirInfo.Root}");
            Console.ReadLine();
        }
        static void AccederNavegarConDirectoryInfoYFile()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
            Console.WriteLine($"{imageFiles.Length} *.jpg archivos encontrados\n");
            foreach (FileInfo f in imageFiles)
            {
                Console.WriteLine("************************************");
                Console.WriteLine($"Nombre {f.Name}");
                Console.WriteLine($"Tamaño {f.Length} bytes");
                Console.WriteLine($"Creación {f.CreationTime.ToShortDateString()}");
                Console.WriteLine($"Atributos {f.Attributes}");
            }
        }

        static void AccederNavegarConFileInfo(FileInfo f, FileInfo f2) 
        {            
            FileStream fs = f.Create(); // para crear un nuevo archivo          
            // Usar el objeto FileStream
            EscribirConFileStream(fs);
            fs.Close();            
            using (FileStream fs2 = f2.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                // Usar FileStream
               EscribirConFileStream(fs2);
            }
            
        }       

        static void EscribirConFileStream(FileStream fs)
        {
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Agregar linea 1...");
                sw.WriteLine("Agregar linea 2...");
                sw.WriteLine("Agregar Última linea ");
                for (int i = 0; i < 10; i++)
                {
                    sw.Write(i + " ");
                }
                sw.Write(sw.NewLine);
            }
            Console.WriteLine("Archivo creado...");
            fs.Close();
        }

        static void LeerConFileStream(FileStream fs)
        {            
            StreamReader sr = new StreamReader(fs);
            string input = null;
            while((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            fs.Close();
        }

        static void CopiarArchivo(FileInfo file)
        {
            FileStream fileStream = file.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite);
            FileInfo f = new FileInfo("Test3.dat");
            using (FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fileStream.CopyTo(fs);
            }
            fileStream.Close();
        }
    }
}
