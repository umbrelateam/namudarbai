using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Roulette Roulette = new Roulette();
            Roulette.TheMainMenu();
            Console.ReadKey();
        }
    }
}
