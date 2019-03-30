using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "[^\\w]";
            //get all spaces and other signs, like: '.' '?' '!'

            Console.Write("Write something : ");
            string input = Console.ReadLine();

            string[] words = null;
            int i = 0;
            int count = 0;

            Console.WriteLine(input);
            words = Regex.Split(input, pattern, RegexOptions.IgnoreCase);
            for (i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                if (words[i].ToString() == string.Empty)
                    count = count - 1;
                count = count + 1;
            }
            Console.WriteLine("Count of words:" + count.ToString());

            Console.ReadKey();
        }
    }
}