using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            string StringNumber = Console.ReadLine();
            ulong number = Convert.ToUInt64(StringNumber);
            ulong sk;
            for (int i = 0; i < StringNumber.Length; i++)
            {
                sk = number % 10;
                number = (number - sk) / 10;
                Console.WriteLine(sk);
            }
            
            Console.ReadKey();
        }
    }
}
