using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SubString_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something: ");
            String s = Console.ReadLine();
            Regex r = new Regex(@"\s+"); //шаблон (наличие одного или более пробелов)
            s = r.Replace(s, @" "); //проходит по всему тексту и заменяет несколько подряд идущих пробелов ординарными.
            int Words = 0;
            string Letter;
            for (int i = 0; i < s.Length; i++)
            {
                Letter = s.Substring(i, 1);
                if (Letter == " ")
                {
                    Words = Words + 1;
                }
            }
            Console.WriteLine("Amount of Words: {0} ", Words + 1);
            Console.ReadKey();
        }
    }   
}
