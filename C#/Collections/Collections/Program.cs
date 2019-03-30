using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array List
            //ArrayList представляет коллекцию объектов. Данный класс подходит для сохранения вместе разнотипных объектов.

            ArrayList list = new ArrayList();
            list.Add(1.9); //добавляем в список объект типа double 
            list.Add(70); //добавляем в список объект типа int
            list.AddRange(new string[] { "Hello", "world!" }); //добавляем в список строковый массив

            //при необходимости можно сразу заполнить List
            ArrayList List = new ArrayList() { 1.9, 70, "Hello", "world!" };

            //Просмотр объектов
            //Поскольку данная коллекция хранит разные объекты, то в качестве типа перебираемых объектов выбран тип object
            foreach (object Object in list)
            {
                Console.WriteLine(Object);
            }
      
            //Можно удалить элемент
            list.RemoveAt(3);

            //перевернуть список
            list.Reverse();

            //получить элемент по индексу
            Console.WriteLine(list[2]);

            //просмотр обьектов с помощью for
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }



            //List
            //List представляет собой простейший список однотипных обьектов

            List<int> numbers = new List<int>() { 2, 5, 10, 34 };
            numbers.Add(6); // добавление элемента

            numbers.AddRange(new int[] { 7, 8, 9 });

            numbers.Insert(0, 666); //Вставляем на первое место в списке число 666

            numbers.RemoveAt(2); //Удаляем третий элемент

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            List<Person> people = new List<Person>(3);
            people.Add(new Person() { Name = "Denis" });
            people.Add(new Person() { Name = "James" });

            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);
            }



            //Stack
            //Stack представляет коллекцию, которая использует алгоритм LIFO("последний вошел - первый вышел")
            //При такой организации каждый следующий добавленный элемент помещается поверх предыдущего
            //Извлечение из коллекции происходит в обратном порядке - извлекается тот элемент, который находится выше всех в стеке

            //В классе Stack можно выделить два основных метода, которые позволяют управлять элементами:
            //Push - добавляет элемент в стэк на первое место
            //Pop - извлекает и возвращает первый элемент из стэка

            Stack<int> numbers1 = new Stack<int>();

            numbers1.Push(9); // в стеке 9
            numbers1.Push(12); // в стеке 12, 9
            numbers1.Push(25); // в стеке 25, 12, 9

            // так как вверху стека будет находиться число 25, то оно и извлекается
            int stackElement = numbers1.Pop(); // в стеке 12, 9
            Console.WriteLine(stackElement);

            Stack<Person> persons = new Stack<Person>();
            persons.Push(new Person() { Name = "Dominyk" });
            persons.Push(new Person() { Name = "Dioniz" });
            persons.Push(new Person() { Name = "Saulius" });

            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }

            // Первый элемент в стеке
            Person person = persons.Pop(); // теперь в стеке Bill, Tom
            Console.WriteLine(person.Name);



            //Queue
            //Queue представляет обычную очередь, работающую по алгоритму FIFO ("Первый вошел - первый вышел")
            //У класса Queue можно отметить следующие методы:
            //Dequeue: извлекает и возвращает первый элемент очереди
            //enqueue: добавляет элемент в конец очереди

            Queue<int> numbers3 = new Queue<int>();

            numbers3.Enqueue(9); // очередь 9
            numbers3.Enqueue(7); // очередь 7, 9
            numbers3.Enqueue(1); // очередь 1, 7, 9

            // получаем первый элемент очереди
            int queueElement = numbers3.Dequeue(); //теперь очередь 7, 9
            Console.WriteLine(queueElement);

            Queue<Person> persons2 = new Queue<Person>();
            persons2.Enqueue(new Person() { Name = "Saulius" });
            persons2.Enqueue(new Person() { Name = "Dominyk" });
            persons2.Enqueue(new Person() { Name = "Dioniz" });

            // получаем первый элемент без его извлечения
            Person pp = persons.Peek();
            Console.WriteLine(pp.Name);

            Console.WriteLine("People waiting in line: {0}", persons.Count);

            // теперь в очереди Saulius, Dominyk, Dioniz
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }

            // Извлекаем первый элемент в очереди - Saulius
            Person person2 = persons2.Dequeue(); // теперь в очереди Dominyk,Dioniz
            Console.WriteLine(person.Name);



            //Dictionary
            //Словарь хранит объекты, которые представляют пару ключ-значение.
            //Каждый такой объект является объектом структуры KeyValuePair<TKey, TValue>.
            //Благодаря свойствам Key и Value, которые есть у данной структуры, мы можем получить ключ и значение элемента в словаре.


            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(1, "Germany");
            countries.Add(3, "Russia");
            countries.Add(2, "France");
            countries.Add(4, "USA");
            countries.Add(5, "China");

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            // получение элемента по ключу
            string country = countries[1];
            // изменение объекта
            countries[5] = "Spain";
            // удаление по ключу
            countries.Remove(3);

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Dictionary<char, Person> People = new Dictionary<char, Person>();
            People.Add('b', new Person() { Name = "Bill" });
            People.Add('t', new Person() { Name = "Tom" });
            People.Add('j', new Person() { Name = "John" });

            foreach (KeyValuePair<char, Person> keyValue in People)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }

            // просмотр ключей
            foreach (char c in People.Keys)
            {
                Console.WriteLine(c);
            }

            // просмотр по значениям
            foreach (Person p in People.Values)
            {
                Console.WriteLine(p.Name);
            }


            //В C# 5.0 мы могли инициализировать словари следующим образом

            Dictionary<string, string> countries1 = new Dictionary<string, string>
            {
                {"France", "Paris"},
                {"Germany", "Berlin"},
                {"Great Britain", "London"}
            };

            foreach (var pair in countries1)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);

            //То начиная с C# 6.0 (Visual Studio 2015) доступен также еще один способ инициализации:

            Dictionary<string, string> countries3 = new Dictionary<string, string>
            {
                ["France"] = "Paris",
                ["Germany"] = "Berlin",
                ["Great Britain"] = "London"
            };



            //LinkedList
            //LinkedList представляет двухсвязный список, в котором каждый элемент хранит ссылку одновременно на следующий и на предыдущий элемент.
            //В LinkedList<T> каждый узел представляет объект класса LinkedListNode<T>. Этот класс имеет следующие свойства:
            //Value: значение узла, представленное типом T
            //Next: ссылка на следующий элемент типа LinkedListNode в списке. 
            //Если следующий элемент отсутствует, то имеет значение null
            //Previous: ссылка на предыдущий элемент типа LinkedListNode<T> в списке
            //Если предыдущий элемент отсутствует, то имеет значение null

            //Используя методы класса LinkedList<T>, можно обращаться к различным элементам, как в конце, так и в начале списка:
            //AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode): вставляет узел newNode в список после узла node.
            //AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode): вставляет в список узел newNode перед узлом node.
            //AddFirst(LinkedListNode<T> node): вставляет новый узел в начало списка.
            //AddLast(LinkedListNode<T> node): вставляет новый узел в конец списка.
            //RemoveFirst(): удаляет первый узел из списка. После этого новым первым узлом становится узел, следующий за удаленным
            //RemoveLast(): удаляет последний узел из списка

            //AddAfter(LinkedListNode<T> node, T value): вставляет в список новый узел со значением value после узла node.
            //AddBefore(LinkedListNode<T> node, T value): вставляет в список новый узел со значением value перед узлом node.
            //AddFirst(T value): вставляет новый узел со значением value в начало списка.
            //AddLast(T value): вставляет новый узел со значением value в конец списка


            LinkedList<int> numbers2 = new LinkedList<int>();

            numbers2.AddLast(4); // вставляем узел со значением 4 на последнее место
            // так как в списке нет узлов, то последнее будет также и первым
            numbers2.AddFirst(3); // вставляем узел со значением 3 на первое место
            numbers2.AddAfter(numbers2.Last, 1); // вставляем после последнего узла новый узел со значением 1
            // теперь у нас список имеет следующую последовательность: 4, 3, 1
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            LinkedList<Person> persons3 = new LinkedList<Person>();

            // добавляем persona в список и получим объект LinkedListNode<Person>, в котором хранится имя Tom
            LinkedListNode<Person> tom = persons3.AddLast(new Person() { Name = "Tom" });
            persons3.AddLast(new Person() { Name = "John" });
            persons3.AddFirst(new Person() { Name = "Bill" });

            Console.WriteLine(tom.Previous.Value.Name); // получаем узел перед томом и его значение
            Console.WriteLine(tom.Next.Value.Name); // получаем узел после тома и его значение

            Console.ReadKey();
        }
    }
}
