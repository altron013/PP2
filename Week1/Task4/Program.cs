using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int i, j, k;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    // Console.Write("");  
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}