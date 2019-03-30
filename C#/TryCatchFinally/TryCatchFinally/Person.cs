using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Person
    {
        private int age;
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new Exception("Persons under 18 are not allowed to register.");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
