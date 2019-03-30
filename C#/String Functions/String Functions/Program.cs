using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Смена Регистра
            String hello = "Hello World!";

            //Для приведения строки к нижнему или верхнему регистру изпользуются соответственно функции ToUpper() или ToLower()

            Console.WriteLine(hello);
            Console.WriteLine(hello.ToLower()); //hello world!
            Console.WriteLine(hello.ToUpper()); //HELLO WORDL!


            //ОбЪединение строк

            String s1 = "hello";
            String s2 = "world";

            //ОбЪединение может производиться как с помощью операции + , так и с помощью метода Concat

            String s3 = s1 + " " + s2 + "!"; // hello world!
            String s4 = String.Concat(s1 + " ", s2, "!!!"); // helloworld!!!
            Console.WriteLine("\n{0}", s3);
            Console.WriteLine(s4);

            //Для объединения строк также может использоваться метод Join

            string s5 = "Apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away.";
            string[] values = new string[] { s5, s6, s7, s8, s9 };

            String s10 = String.Join(" ", values);//строка-разделитель и массив строк, которые будут соединяться и разделяться разделителем
            Console.WriteLine(s10);//apple a day keeps a doctor away


            //Сравнение Строк

            string s11 = "hello";
            string s12 = "world";

            //Для сравнения строк применяется метод Compare

            int result = String.Compare(s11, s12);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
            //Если первая строка по алфавиту стоит выше второй, то возвращается число меньше нуля.
            //В противном случае возвращается число больше нуля. И третий случай - если строки равны, то возвращается число 0.


            //Поиск в строке

            //С помощью метода IndexOf мы можем определить индекс первого вхождения отдельного символа или подстроки в строке

            string s13 = "hello world";
            char ch = 'o';
            int indexOfChar = s13.IndexOf(ch); //  4
            Console.WriteLine("\n{0}", indexOfChar);

            string subString = "wor";
            int indexOfSubstring = s13.IndexOf(subString); // 6
            Console.WriteLine(indexOfSubstring);

            //Также есть еще два метода StartWith и EndsWith которые позволяют узнать начинается или заканчивается ли строка на определенную подстроку.
            //Например, задача удалить из папки все файлы с расширением exe.

            //string path = @"C:\SomeDir";

            //string[] files = Directory.GetFiles(path);

            //for (int i = 0; i < files.Length; i++)
            //{
            //    if (files[i].EndsWith(".exe"))
            //        File.Delete(files[i]);
            //}


            //Разделение строк

            //С помощью функции Split мы можем разделить строку на массив подстрок.
            //В качестве параметра функция Split принимает массив символов или строк, которые и будут служить разделителями.
            //Например, подсчитаем количество слов в строке, разделив ее по пробельным символам.

            string text = "And so it begins";

            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // параметр StringSplitOptions.RemoveEmptyEntries говорит, что надо удалить все пустые подстроки.

            foreach (string s in words)
            {
                Console.WriteLine("\n{0}", s);
            }


            //Обрезка строки

            //Для обрезки начальных или концевых символов используется функция Trim.

            string text2 = " hello world ";
            Console.WriteLine("\n{0}", text2);

            //Функция Trim без параметров образает начальные и конечные пробелы и возвращает обрезаннную строку.
            text2 = text2.Trim(); //"hello world"
            Console.WriteLine(text2);

            //Чтобы явным образом указать, какие начальные и конечные символы следует обрезать, мы можем передать в функцию массив этих символов.
            text2 = text2.Trim(new char[] { 'd', 'h' }); //"ello worl"
            Console.WriteLine(text2);
            //Имеются частичные аналоги: TrimStart(обрезает начальные символы) и TrimEnd(обрезает конечные символы).

            //Обрезать определенную часть строки позволяет функция SubString.

            string text3 = "Хороший день";
            Console.WriteLine(text3);

            // обрезаем начиная с третьего символа
            text3 = text3.Substring(2);
            // результат "роший день"
            Console.WriteLine(text3);

            // обрезаем сначала до последних двух символов
            text3 = text3.Substring(0, text3.Length - 2);
            // результат "роший де"
            Console.WriteLine(text3);


            //Вставка

            //Для вставки одной строки в другую применяется функция Insert.

            string text4 = "Хороший день";
            string subString2 = "замечательный ";

            text4 = text4.Insert(8, subString2); //Первый параметр является индексом, по которому надо вставлять подстроку, а второй это подстрока.
            Console.WriteLine("\n{0}", text4);


            //Удаление строк

            //Удалить часть строки помогает метод Remove.

            // индекс последнего символа
            int ind = text4.Length - 1;
            // вырезаем последний символ
            text4 = text4.Remove(ind);
            Console.WriteLine("\n{0}", text4);

            // вырезаем первые два символа
            text4 = text4.Remove(0, 2);
            Console.WriteLine(text4);


            //Замена

            //Чтобы заменить один символ или подстроку на другую, применяется метод Replace.

            string text5 = "хороший день";

            text5 = text5.Replace("хороший", "плохой");
            Console.WriteLine("\n{0}", text5);

            text5 = text5.Replace("о", "");
            Console.WriteLine(text5);

            Console.ReadKey();
        }
    }
}
