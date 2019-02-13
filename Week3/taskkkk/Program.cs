using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void print(DirectoryInfo d, int cursor)// будет хранить информацию про папки и курсор
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();
            FileSystemInfo[] fsis = d.GetFileSystemInfos();// cоздаем массив и даем ему значение файлов и документов
            for (int i = 0; i < fsis.Length; i++) // проходим по массиву
            {

                if (fsis[i].GetType() == typeof(DirectoryInfo)) // если элемент массива является тип папки 
                {
                    Console.ForegroundColor = ConsoleColor.Red; //то цвет шрифта -красный 
                }
                if (fsis[i].GetType() == typeof(FileInfo)) // если элемент массива является тип папки
                {
                    Console.ForegroundColor = ConsoleColor.Green;//  то цвет  шрифта -зеленый 
                }
                if (i == cursor)  //цвет шрифта где стоит курсор серый 
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;// все остальные черные 
                }
                Console.WriteLine(fsis[i].Name); //  выводим
            }

        }
        static void Main(string[] args)
        {
            string path = @"C:\git\PP2\lab1"; //даем путь к папке 
            DirectoryInfo d = new DirectoryInfo(path);// это для файлов  и для папки
            int cursor = 0; // создаем курсор
            print(d, cursor); //вызываем  функциб для директории и крусора
            int n = d.GetFileSystemInfos().Length; // количество элементов в директории 

            while (true) // запускаем вечный цикл,чтобы обнавлять каждый раз юкогда мы читаем клавишу
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();//читаем клавишу
                FileSystemInfo[] fsis = d.GetFileSystemInfos();//массив элемента в директории
                if (keyInfo.Key == ConsoleKey.UpArrow) // если при нажатии стрелки вверх курсор уходит за грань,то нужно его перенести в самый низ
                {
                    cursor--; // курсор уменьшается 
                    if (cursor == -1)
                    {
                        cursor = n - 1;// n eto грань 
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow) // если при нажатии стрелки вниз курсор уходит  за грань, то нужно его пернести на первый элемент
                {
                    cursor++; // курсор увеличивается 
                    if (cursor == n)
                    {
                        cursor = 0;// первый элемент это нулевой элемент
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter) // при нажатии enter
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo)) //esli tip togo elementa na kotorom nahoditsya cursor yavlyaetsya  papka to delai eto
                    {
                        d = new DirectoryInfo(fsis[cursor].FullName);//зайти в эту папку
                        n = d.GetFileSystemInfos().Length;
                        cursor = 0; //обнулить курсор 
                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo)) //esli tip togo elementa na kotorom nahoditsya cursor yavlyaetsya filom to delai eto
                    {
                        StreamReader sr = new StreamReader(fsis[cursor].FullName);// прочитать это 
                        Console.Clear();
                        Console.WriteLine(sr.ReadToEnd()); // прочитать до конца 
                        Console.ReadKey();
                    }
                }
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    if (d.Parent != null) //  если у него есть родитель
                    {
                        d = d.Parent; // то д является его родителем
                        n = d.GetFileSystemInfos().Length;// v novom puti u nas kolichestvo elementov drugoe
                        cursor = 0;// chtob s nulya nachinalsya kazhdiy raz kogda vyhodim ili zahodim
                    }
                    else
                    {
                        break;//если никуда не надо ,то не нужно
                    }
                }
                if (keyInfo.Key == ConsoleKey.D) // при нажатии д 
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo)) //если элемент на котором стоит курсор -папка
                    {
                        Directory.Delete(fsis[cursor].FullName); // polniy put' k faliu/directorii
                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo))
                    {
                        File.Delete(fsis[cursor].FullName);// удалить этот файл
                    }
                }
                if (keyInfo.Key == ConsoleKey.R) // 
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        Console.Clear();
                        string s = Console.ReadLine();
                        string fileName = fsis[cursor].Name;
                        string dirPath = fsis[cursor].FullName;
                        int len = fileName.Length;
                        string newpath = "";
                        for (int i = 0; i < dirPath.Length - len; i++)
                        {
                            newpath = newpath + dirPath[i];
                        }
                        newpath = newpath + s;
                        Directory.Move(dirPath, newpath);
                    }
                    if (fsis[cursor].GetType() == typeof(FileInfo))
                    {
                        Console.Clear();
                        string s = Console.ReadLine();// просим написать новое называние 
                        string fileName = fsis[cursor].Name; //text.txt 
                        string dirPath = fsis[cursor].FullName; //C:\Users\User\Desktop\text.txt 
                        int len = fileName.Length; //8
                        string newpath = "";
                        for (int i = 0; i < dirPath.Length - len; i++)
                        {
                            newpath = newpath + dirPath[i];
                        }
                        newpath = newpath + s;
                        File.Move(dirPath, newpath);
                    }
                }
                print(d, cursor); //potomu chto consolekeyinfo nuzhno kazdiy raz schytvyat'
            }
        }
    }
}