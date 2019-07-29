using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteGame.BusinessEntities;
using RouletteGame.BusinessServices;
using RouletteGame;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            UserInterface UI = new UserInterface();
            RouletteEntity RE = new RouletteEntity();
            UserEntity UE = new UserEntity(5000);
            RouletteServices RS = new RouletteServices();
            RS.TheMainMenu(RE, UE, UI);
            Console.ReadKey();
        }
    }
}
