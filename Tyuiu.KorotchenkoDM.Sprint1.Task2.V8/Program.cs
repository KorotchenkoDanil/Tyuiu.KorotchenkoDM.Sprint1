using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorotchenkoDM.Sprint1.Task2.V8.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint1.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Коротченко Д. М. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операции в С#                                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Коротченко Данил Михайлович | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране              *");
            Console.WriteLine("\n* Формулировка задания: Известны длины сторон прямоугольника. Вычислить   *");
            Console.WriteLine("* периметр прямоугольника                                                 *");
            Console.WriteLine("\n* Что пользователь вводит? Длина первой стороны прямоугольника (целое     *");
            Console.WriteLine("* число), длина второй стороны прямоугольника (целое число)               *");
            Console.WriteLine("\n* Что программа печатает на экране? Периметр прямоугольника(целое число)  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите длину первой стороны прямоугольника:                              ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите длину второй стороны прямоугольника:                              ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine(" Периметр прямоугольника = " + ds.CalculatePerimetr(a, b));

            Console.ReadKey();
        }
    }
}
