using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Color
    {
        public string name;
        public int number = new int();
        public Random randomizer = new Random();

        public Color(string nm, int num1, int num2)
        {
            name = nm;
            number = randomizer.Next(num1, num2);
        }
    }
}
