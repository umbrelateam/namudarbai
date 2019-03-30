using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //делегаты - это указатели на методы
    //с помощью которых мы можем вызывать данные методы.
    //Если делегат возвращает некоторое значение, то возвращается значение последнего метода из списка вызова.
    class Program
    {
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }

        private static void GoodMorning(string name)
        {
            Console.WriteLine("Good Morning, {0}", name);
        }
        private static void GoodEvening(string name)
        {
            Console.WriteLine("Good Evening, {0}", name);
        }

        private static void Hello()
        {
            Console.WriteLine("Hello!");
        }
        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }

        private static void Show_Message(GetMessage showMes)
        {
            showMes?.Invoke();//с помощью Invoke можно проверять, не равен ли делегат null.
            //В случае если делегат пуст ошибки не будет. Делегат просто не будет вызываться.
        }

        delegate int Operation(int x, int y);
        //Делегат Operation имеет тип int и принимает два параметра типа int.
        //Поэтому этому делегату подходит любой метод, который возвращает int и принимает два параметра int.
        delegate void Message(string name);
        //Делегат message имеет тип void и не принимает никаких параметров.
        //Этот делегат может указывать на любой метод, который не принимает никаких параметров и ничего не возвращает.

        delegate void GetMessage();

        //Делегат может быть обобщенным
        delegate T Operation<T, K>(K val);

        static void Main(string[] args)
        {
            Message mes;
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;//присваиваем переменной адрес метода. 
            }
            else
            {
                mes = GoodEvening;
            }
            mes("Dominyk");

            Operation op = Add;
            int result = op(4, 5);
            Console.WriteLine(result);

            op = Multiply;
            result = op(4, 5);
            Console.WriteLine(result);

            Message mes1 = Hello;
            //mes1 += HowAreYou; //теперь mes1 имеет два метода.
            //mes1();
            //mes1 -= Hello; //удаление одного из методов. 
            //mes1();

            Message mes2 = mes + mes1;
            mes2("Dionizas");

            //Делегат как параметр метода
            if (DateTime.Now.Hour < 12)
            {
                //Show_Message(GoodMorning);
            }
            else
            {
                //Show_Message(GoodEvening);
            }


            Console.ReadKey();
        }
    }
}