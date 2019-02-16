using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter New = new StreamWriter(@"C:\git\PP2\lab1\5.txt");
            New.Write(3333);
            New.Close();

            File.Copy(@"C:\git\PP2\lab1\5.txt", @"C:\git\PP2\lab1\6.txt");
            File.Delete(@"C:\git\PP2\lab1\5.txt");
        }
    }
}






/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {

        public static void Main(string[] args)
        {
            CreateFile();
            CopyFile();
            DeleteFile();
           
        }


        static void CreateFile()
        {
            string folderName = @"C:\Papke";
            string pathString = System.IO.Path.Combine(folderName, "SubPapke");
            System.IO.Directory.CreateDirectory(pathString);
            string fileName = "papke.txt";
            pathString = System.IO.Path.Combine(pathString, fileName);
            Console.WriteLine("Path to my file: {0}\n", pathString);

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }
            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
                foreach (byte b in readBuffer)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            CopyFile();
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }




        public static void CopyFile()
        {
            string fileName = "papke.txt";
            string sourcePath = @"C:\Papke\SubPapke";
            string targetPath = @"C:\Users\Lenovo\Desktop\paapka";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        public static void DeleteFile()
        {
            if (System.IO.File.Exists(@"C:\Papke\SubPapke\papke.txt"))
            {
                try
                {
                    System.IO.File.Delete(@"C:\Papke\SubPapke\papke.txt");
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }
    }
}
*/
