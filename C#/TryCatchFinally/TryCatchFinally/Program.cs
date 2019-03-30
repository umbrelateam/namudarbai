using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;     // IndexOutOfRangeException

                int x = 5;
                int y = x / 0; //DivideByZeroException
                Console.WriteLine($"Result: {y}");
            }
            catch (DivideByZeroException s)
            {
                Console.WriteLine(s.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Следует отметить, что в данном случае в блоке try есть ситуация для генерации второго исключения - деление на ноль.
            //Однако поскольку после генерации IndexOutOfRangeException управление переходит в соответствующий блок catch,
            //то деление на ноль int y = x / 0 в принципе не будет выполняться, поэтому исключение типа DivideByZeroException никогда не будет сгенерировано.
            //--------------------------------------------//
            try
            {
                Console.Write("Write something: ");
                string message = Console.ReadLine();
                if (message.Length > 6)
                {
                    throw new Exception("Lenght of your message is longer than 6 symbols");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            //--------------------------------------------//


            {
                try
                {
                    Person p = new Person { Name = "Dominyk", Age = 15 };
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.Read();
            }
            //--------------------------------------------//


            try
            {
                object obj = "you";
                int num = (int)obj;     // InvalidCastException
                Console.WriteLine($"Result: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occurred: DivideByZeroException!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Exception occurred: IndexOutOfRangeException!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            //--------------------------------------------//

            Console.WriteLine("Enter the number");
            int a;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out a))//Метод Int32.TryParse() возвращает true, если преобразование можно осуществить, и false - если нельзя.
                                             //При допустимости преобразования переменная x будет содержать введенное число.
            {
                a *= a;
                Console.WriteLine("Square number: " + a);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadKey();
        }
    }
}
