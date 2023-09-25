using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorotchenkoDM.Sprint1.Task3.V4.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint1.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Коротченко Д. М. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Коротченко Данил Михайлович | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране              *");
            Console.WriteLine("\n* Расчеты:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости покупки, состоящей из           *");
            Console.WriteLine("* нескольких тетрадей и такого же количества обложек к ним                *");
            Console.WriteLine("\n* Цена тетради (руб) -> 2.75                                              *");
            Console.WriteLine("* Цена обложки (руб) -> 0.5                                               *");
            Console.WriteLine("* Количество комплектов (шт) -> 7                                         *");
            Console.WriteLine("* Стоимость покупки: 22.75 руб                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите цену тетради:                                                      ");
            double priceNotebook = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену обложки:                                                      ");
            double priceCover = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество комплектов:                                             ");            
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Стоимость покупки: " + ds.PurchaseAmount(priceNotebook, priceCover, amount));

            Console.ReadKey();
        }
    }
}
