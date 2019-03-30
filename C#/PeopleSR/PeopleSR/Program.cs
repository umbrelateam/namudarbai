using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PeopleSR
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonService person = new PersonService();
            person.WriteTofile(@"People.csv");
            Console.ReadKey();
        }
    }
}
