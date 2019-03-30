using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubString_aCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something: ");
            String s = Console.ReadLine();
            int aCount = 0;
            string Letter;
            for (int i = 0; i < s.Length; i++)
            {
                Letter = s.Substring(i, 1);
                if (Letter == "a")
                {
                    aCount = aCount + 1;
                }               
            }
            Console.WriteLine("Amount of 'a' Letters: {0} ", aCount);
            Console.ReadKey();
        }
    }
}
