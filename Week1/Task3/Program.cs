using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pr = Console.ReadLine(); // reads the line1 input string, size of elements(input)
            string kr = Console.ReadLine(); // reads the line2 input which is also string(input)

            int n = int.Parse(pr); // converting to integer by intParse function
            string[] numsStr = kr.Split();// string array created which will be readed by every element

            for (int i = 0; i < numsStr.Length; ++i) //loop which checks each element of an array
            {
                int x = int.Parse(numsStr[i]);// 
                for (int j = 0; j < 2; ++j)// copies evry element of numStr to times  
                {
                    Console.Write(x + " ");// shows coppied array to the screen 
                }

            }
        }
    }
}