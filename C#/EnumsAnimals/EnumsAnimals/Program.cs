using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAnimals
{
    class Program
    {
        //Перечисления представляют набор логически связанных констант.
        //Объявление перечисления происходит с помощью оператора enum.
        //Далее идет название перечисления, после которого указывается тип перечисления - он обязательно должен представлять целочисленный тип (byte, int, short, long).
        //По умолчанию используется тип int
        //enum нужен для того, чтобы заменить обычные значения на константу.
        enum Animals { Lion, Monkey, Dog, Cat, Snake, Elephant }


        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        static void MathOp(double x, double y, Operation Math)
        {
            double result = 0.0;
            //Конструкция switch/case похожа на конструкцию if/else, так как позволяет обработать сразу несколько условий.
            //После ключевого слова switch в скобках идет сравниваемое выражение.
            //Значение этого выражения последовательно сравнивается со значениями, помещенными после оператора сase.
            //И если совпадение будет найдено, то будет выполняться определенный блок сase.
            //В конце каждого блока сase должен ставиться один из операторов перехода: break, goto case, return или throw.
            //Как правило, используется оператор break. При его применении другие блоки case выполняться не будут.
            switch (Math)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }

            Console.WriteLine("Result is: {0}", result);
        }

        static void Main(string[] args)
        {

            foreach (int animal in Enum.GetValues(typeof(Animals)))
            {
                Console.WriteLine(animal);                    
            }

            foreach (Animals animal in (Animals[])Enum.GetValues(typeof(Animals)))
            {
                Console.WriteLine(animal);
            }

            MathOp(10, 5, Operation.Add);
            MathOp(11, 5, Operation.Multiply);
            MathOp(8, 9, Operation.Subtract);
            MathOp(20, 15, Operation.Divide);

            Console.ReadLine();
        }
    }
}
