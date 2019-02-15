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
            StreamWriter New = new StreamWriter(@"C:\5.txt");
            New.Write(3333);
            New.Close();

            File.Copy(@"C:\5.txt", @"C:\6.txt");
            File.Delete(@"C:\5.txt");
        }
    }
}
