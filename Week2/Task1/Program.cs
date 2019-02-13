using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\git\PP2\lab1\Week2\Task1\TextFile1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadToEnd();

            string reverse = string.Empty;
            int length = text.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + text[length];
                length--;
            }


            if (text == reverse) { Console.WriteLine("Yes"); }
            else if (text != reverse) { Console.WriteLine("No"); }
            sr.Close();
            fs.Close();
        }

    }
}
