using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Value_Of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first Number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second Number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine(first);
            }

            else if (first < second)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }
            Console.ReadKey();
        }
        
    }
}
