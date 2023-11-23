using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint5.Task6.V11.Lib;

namespace Tyuiu.IvanovJD.Sprint5.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Иванов Я.Д. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Иванов Я.Д. | ПКТб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*   Найти количество слов длиной 6 символов в заданной строке..           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();

            string path = @"C:\Users\yarik\source\repos\Tyuiu.IvanovJD.Sprint5\Tyuiu.IvanovJD.Sprint5.Task6.V11\bin\Debug\InPutDataFileTask6V11.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество слов из 6 букв: " + res);
            Console.ReadKey();
        }
    }
}