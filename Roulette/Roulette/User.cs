using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class User
    {
        public int balance = new int();
        public int attempts = new int();

        public void ShowBalance()
        {
            Console.WriteLine("Your balance is : {0} Attempts : {1}", balance, attempts);
        }
        public User(int u)
        {
            balance = u;
        }
    }
}
