using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //В интерфейсы можно записывать методы и свойства, но их реализация будет происходит в классах наследниках.
    //В абстрактном классе методы могут быть реализованны в том же классе.
    //Когда мы используем интерфейс на классе, класс ДОЛЖЕН реализовать все методы и свойства, иначе будет выдоваться ошибка
    //Интерфейс не может содержать в себе переменные.
    //Интерфейсы нужны для множественного наследования, что нельзя сделать с абстрактными классами.
    //Все члены интерфейса (Методы и Свойства), не имеют модификаторов доступа, но фактически по умолчанию доступ стоит public,
    //так как цель интерфейса - определение функционала для реализации его классом. Весь функционал должен быть открыт для реализации.
    //Иными словами, интерфейс - это контракт, что какой-то определенный тип обязательно реализует функционал интерфейса.
    interface IMove
    {
        void Move();
    }

    interface IDoSomething
    {
        void DoSomething();
        int Amount { get; set; }
        void Print();
    }

    class TestClass : IDoSomething
    {
        public void DoSomething()
        {
            Console.WriteLine("It's doing something!");
        }

        public int Amount { get; set; }

        public void Print()
        {
            Console.WriteLine(Amount);
        }
    }

    class TestCLass2 : IDoSomething
    {
        public void DoSomething()
        {
            Console.WriteLine("\nIt's doing something in another way!");
        }

        public int Amount { get; set; }

        public void Print()
        {
            Console.WriteLine(Amount);
        }
    }

    class Person : IDoSomething, IMove
    {
        public string Name { get; set; }

        public void DoSomething()
        {
            Console.WriteLine("\n{0} is buying something in the store!", Name);
        }

        public int Amount { get; set; }

        public void Print()
        {
            Console.WriteLine("\nAmount of products {0} bought in the store: {1}", Name, Amount);
        }

        public void Move()
        {
            Console.WriteLine("\n{0} is moving back to his home.", Name);
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            TestClass Test = new TestClass();
            TestCLass2 Test2 = new TestCLass2();
            Person person = new Person();

            Test.Amount = 5;
            Test.DoSomething();
            Test.Print();

            Test2.Amount = 10;
            Test2.DoSomething();
            Test2.Print();

            person.Name = "Dominyk";
            person.Amount = 17;
            person.DoSomething();
            person.Print();
            person.Move();

            Console.Read();
        }
    }
}
