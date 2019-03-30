using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для работы с датами и временем  предназначена структура DateTime.
            //Она представляет дату и время от 00:00:00 1 января 0001 года до 23:59:59 31 декабря 9999 года.
            //Для создания нового объекта DateTime можно использовать конструктор.Пустой конструктор создает начальную дату.

            DateTime date1 = new DateTime();
            Console.WriteLine(date1); // 01.01.0001 0:00:00

            //Получим минимально возможное значение, которое также можно получить следующим образом
            Console.WriteLine(DateTime.MinValue);
            //Чтобы задать конкретную дату и время, нужно использовать один из конструкторов, принимающих параметры.

            DateTime date2 = new DateTime(2018, 11, 7, 18, 27, 50); // год - месяц - день - час - минута - секунда
            Console.WriteLine(date2);

            //Если надо получить текущие время и дату, то можно ряд свойств DateTIme

            Console.WriteLine(DateTime.Now); //Время и дата компьютера
            Console.WriteLine(DateTime.UtcNow); //Дата и время относительно по Гринвичу
            Console.WriteLine(DateTime.Today); //Только текущая дата

            //Основные операции со структурой DateTime связаны со сложением или вычитанием дат. 
            //Например, надо к некоторой дате прибавить или, наоборот, отнять несколько дней.

            //Для добавления дат используется ряд методов:
            //date1.Add(DateTime date): добавляет дату
            //date1.AddDays(double value): добавляет к текущей дате несколько дней
            //date1.AddHours(double value): добавляет к текущей дате несколько часов
            //date1.AddMinutes(double value): добавляет к текущей дате несколько минут
            //date1.AddMonths(int value): добавляет к текущей дате несколько месяцев
            //date1.AddYears(int value): добавляет к текущей дате несколько лет

            //Для вычитания дат используется метод Substract(DateTime date)
            DateTime date3 = new DateTime(2018, 11, 7, 18, 27, 50);
            DateTime date4 = new DateTime(2018, 11, 7, 14, 27, 50);
            Console.WriteLine(date3.Subtract(date4)); // 04:00:00

            //Метод Substract не имеет возможностей для отдельного вычитания дней, часов и так далее.
            //Но это и не надо, так как мы можем передавать в метод AddDays() и другие методы добавления отрицательные значения.
            Console.WriteLine(date3.AddHours(-4)); //2018.11.7 14:27:50
            Console.WriteLine(date3.AddDays(-4)); //2018.11.3 18:27:50
            Console.WriteLine(date3.AddMinutes(-4)); //2018.11.7 18:23:50
            Console.WriteLine(date3.AddMonths(-4)); //2018.7.7 18:27:50
            Console.WriteLine(date3.AddSeconds(-4)); //2018.11.7 18:27:46
            Console.WriteLine(date3.AddYears(-4)); //2014.11.7 18:27:50
            //Кроме операций сложения и вычитания еще есть ряд методов форматирования дат.
            Console.WriteLine(date3.ToLocalTime()); //07.11.2018 20:27:50
            Console.WriteLine(date3.ToUniversalTime()); //07.11.2018 16:27:50
            Console.WriteLine(date3.ToLongDateString()); //7 ноября 2018 г.
            Console.WriteLine(date3.ToShortDateString()); //07.11.2018
            Console.WriteLine(date3.ToLongTimeString()); //18:27:50
            Console.WriteLine(date3.ToShortTimeString()); //18:27
            Console.ReadKey();
        }
    }
}
