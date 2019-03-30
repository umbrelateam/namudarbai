using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsVsNonGenerics
{
    class Account<T>
    {
        public T ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 55;
            int y = 13;
            Swap<int>(ref x,ref y);
            Console.WriteLine($"x={x}  y={y}");

            string s1 = "Hello!";
            string s2 = "Goodbye!";
            Swap<string>(ref s1,ref s2);
            Console.WriteLine($"s1={s1}  s2={s2}");


            Account<int> account1 = new Account<int>();
            Account<string> account2 = new Account<string>();
            account1.ID = 45;
            account2.ID = "1354";
            Console.WriteLine($"account1 ID: {account1.ID}  account2 ID: {account2.ID}");

            Console.ReadLine();
        }


        //static - ??
        public static void Swap<T>(ref T x,ref T y)// ref - изменение переменной в методе. указывает на определенные данные, но не хранит их.то, что происходит внутри метода никак не отразится на оригинали без ref.
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
