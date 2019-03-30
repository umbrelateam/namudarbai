using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PeopleSR
{
    public class PersonService
    {
        public List<Person> ReadFromFile(string FileName)
        {
            List<Person> people = new List<Person>();
            String csv;
            for (int i = 0; i < 3; i++)
            {
                csv = File.ReadLines(FileName).Skip(i + 1).First();
                string[] Line = csv.Split(',');
                Person person = new Person();
                person.Name = Line[0];
                person.Surname = Line[1];
                person.Age = Convert.ToInt32(Line[2]);
                person.Height = Convert.ToInt32(Line[3]);
                person.Adress = Line[4];
                people.Add(person);
            }
            return people;
        }
        public void WriteTofile(String FileName)
        {
            List<Person> people = ReadFromFile(FileName);
            foreach (Person person in people)
            {
                person.DisplayInfo();
            }
        }
    }
}
