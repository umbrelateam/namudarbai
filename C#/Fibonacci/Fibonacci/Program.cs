using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Until what number count Fibonacci series? ");
            int number = Convert.ToInt32(Console.ReadLine());
            int First = 1;
            Console.WriteLine(First);
            int Second = 1;
            Console.WriteLine(Second);
            int sum = 0; 
            while (number >= sum)
            {
                sum = First + Second;

                Console.WriteLine(sum);

                First = Second;
                Second = sum;
            }
            Console.ReadKey();
        }
    }
}
