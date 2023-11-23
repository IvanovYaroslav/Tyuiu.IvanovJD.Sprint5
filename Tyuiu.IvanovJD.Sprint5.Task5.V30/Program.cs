using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint5.Task5.V30.Lib;

namespace Tyuiu.IvanovJD.Sprint5.Task5.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Иванов Я.Д. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Иванов Я.Д. | ПКТб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С: DataSprint5 InPutDataFileTask5V26.txt (файл взять из архива *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С: DataSprint5  и      *");
            Console.WriteLine("* скопировать в неё файл). Найти максимальное целое число в файле         *");
            Console.WriteLine("* которое является простым числом/            Результат округлить до 3    *");
            Console.WriteLine("* знаков после запятой. Полученный результат вывести на консоль.          *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask5V30.txt";

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + res);


            Console.ReadKey();
        }
    }
}