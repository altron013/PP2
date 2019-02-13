using System;//The first line of the program using System; - the using keyword is used to include the System namespace in the program. 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1 //collection of classes and name of project reshenie
{
    public class Program //data and method definitions that your program uses.
    {
        public static bool isPrime(int n)// bool is available value type in program(which can have to possible solution true or false)// function which identify is the number prime or not
        {
            if (n < 2) return false;//if statemrnt which returns false if the int n larger than two
            for (int i = 2; i < n; ++i) //for loop which starts from 2 and checks all i till the n
            {
                if (n % i == 0) return false; // проеверяем на остаток если остаток равен нулю то решение будет фолс
            }
            return true;
        }

        public static void Main(string[] args) //The Main method states what the class does when executed.
        {
            int n = int.Parse(Console.ReadLine());// creating int n(size of array),int is variable which cannot readble by c#,here we expect it to always be an integer by intParse function;

            int[] arr = new int[n];// creating an array with n size;

            string[] parts = Console.ReadLine().Split();// writing input and reading it by parts

            int cnt = 0;// integer in order to count number of prime numbers.
            for (int i = 0; i < parts.Length; ++i)// loop which will be used to check each number for prime.
            {
                arr[i] = int.Parse(parts[i]);
                if (isPrime(arr[i])) cnt++;// cnt at the first stage equals to 0,it will be inlarged by one if there prime number.
            }
            Console.WriteLine(cnt);// shows in the screen the count of prime numbers
            for (int i = 0; i < arr.Length; ++i)
            {
                if (isPrime(arr[i]))
                    Console.Write(arr[i] + " "); //This statement shows the array of prime numbers in the screen.
            }

        }
    }
}

