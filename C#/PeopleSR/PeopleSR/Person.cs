using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleSR
{
    public class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public double Height;
        public string Adress;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name = {Name}; Surname = {Surname}; Age = {Age}; Height = {Height}; Adress = {Adress}");
        }
    }
}
