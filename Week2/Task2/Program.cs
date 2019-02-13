using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    public class Program
    {
        public static bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; ++i)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\git\PP2\lab1\Week2\Task2\TextFile1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            FileStream fs2 = new FileStream(@"C:\git\PP2\lab1\Week2\Task2\TextFile2.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);

            string text = sr.ReadLine();
            string[] arr = text.Split();

            for (int i = 0; i < arr.Length; ++i)
            {
                int x = int.Parse(arr[i]);
                if (isPrime(x)) { sw.Write(x + " "); }
            }

            sw.Close();
            fs2.Close();

            sr.Close();
            fs.Close();
        }
    }
}

