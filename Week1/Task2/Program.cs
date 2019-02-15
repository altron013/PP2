using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class program
    {
        class student // создаем новый класс для класса 

        {
            public string n;// заявляем общедоступную строку имени 
            public string id;//заявляем общедоступную строку айдишки
            public int y;//заявляем общедоступную строку год обучение 
            public student(string name, int year)// конструктор с двумя пармаетрами 
            {
                n = name; // это имя
                y = year; //у это год
            }
            public void yea() // функия инкремента для года
            {
                y++; //увеличеваем год на один
            }
            public void PrintInfo()  //функция ввыода
            {
                Console.WriteLine(n); //выводим имени
                Console.WriteLine(id);// выводим айдишку
                Console.WriteLine(y);// выводим год


            }
            static void Main(string[] args)
            {
                student a = new student("Nurly", 1);// новый класс с двумя параметрами 
                a.id = "18BD110101";// даем ему айдишку
                a.yea();// выводим метолд инкрементиа
                a.PrintInfo();// вызываем  метод вывода
            }
        }

    }
}

