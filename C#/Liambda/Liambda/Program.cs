
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liambda
{
    class Program
    {
        delegate void Hello();
        static void Main(string[] args)
        {
            //1)Анонимный метод(метод в методе),2)обобщенный делегат.
            Func<int, int, int> funcPlus = delegate (int x, int y) { return x + y; };
            //Лямбда
            Func<int, int, int> funcPlusLiambda = (x, y) => x + y;

            Func<int, int, int> funcMinus = delegate (int x, int y) { return x - y; };
            Func<int, int, int> funcMinusLiambda = (x, y) => x - y;

            Hello hello1 = () => Console.WriteLine("Hello!");
            Hello hello2 = () => Console.WriteLine("Welcome!");
            Hello message = () => Message();
            message();
            hello1();
            hello2();

            int result = funcPlus(3, 2);
            Console.WriteLine(result);

            result = funcPlusLiambda(2, 3);
            Console.WriteLine(result);

            result = funcMinus(3, 2);
            Console.WriteLine(result);

            result = funcMinusLiambda(3, 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static void Message()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
