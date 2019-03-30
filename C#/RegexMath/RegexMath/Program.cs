using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexMath
{
    class Program
    {
        static void Main(string[] args)
        {//Регулярные выражения представляют эффективный и гибкий метод по обработке больших текстов,
         //позволяя в то же время существенно уменьшить объемы кода по сравнению с использованием стандартных операций со строками.
         //центральным классом при работе с регулярными выражениями является класс Regex.
            Regex MathFinder = new Regex("math", RegexOptions.IgnoreCase); //Игнорирование регистра (math=словоформa)

            List<string> MyBooks = new List<string>();
            MyBooks.Add("Physics, 9th Class");
            MyBooks.Add("Chemistry, 9th Class");
            MyBooks.Add("Chemistry(Russian), 9th Class");
            MyBooks.Add("Geography, 9th Class");
            MyBooks.Add("Mathematics(Part 1), 9th Class");
            MyBooks.Add("English, 9th Class");
            MyBooks.Add("Biology, 9th Class");
            MyBooks.Add("Mathematics(Part 2), 9th Class");
            MyBooks.Add("History, 9th Class");
            MyBooks.Add("Economics, 9th Class");

            foreach (string Book in MyBooks)
            {
                if (MathFinder.IsMatch(Book))
                    Console.WriteLine(Book);
            }
            Console.Read();
        }
    }
}