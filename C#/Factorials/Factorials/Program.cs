using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.Write("Enter the Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadKey();
        } 
    }
}
