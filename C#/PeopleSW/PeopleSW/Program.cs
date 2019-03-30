using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PeopleSW
{
    class Program
    {
        public struct Person
        {
            public string Name;
            public string Surname;
            public int Age;
            public double Height;
            public string Adress;
            
        }
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter the person's Name: ");
                people[i].Name = Console.ReadLine();

                Console.Write("Enter the person's Surname: ");
                people[i].Surname = Console.ReadLine();

                Console.Write("Enter the person's Age: ");
                people[i].Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the person's Height: ");
                people[i].Height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the person's Adress: ");
                people[i].Adress = Console.ReadLine();
            }
                StreamWriter SW = new StreamWriter(@"People.txt"); //object that allows you to write to a text file

            for (int i = 0; i < 3; i++)
            {
                SW.WriteLine($"Name = {people[i].Name}; Surname = {people[i].Surname}; Age = {people[i].Age}; Height = {people[i].Height}; Adress = {people[i].Adress}");
                }

                SW.Close();
                Console.ReadKey();
        }
    }
}