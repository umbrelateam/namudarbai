using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    /// <summary>
    /// Main class of the program
    /// </summary>
    public class Roulette
    {
        User u = new User(5000);
        Color c1 = new Color("Red",0, 50);
        Color c2 = new Color("Black", 50, 100);
        string[] color = { "Red", "Black"};
        Random r = new Random();
        int bet = new int();
        string guess;
        int number = new int();

        /// <summary>
        /// TheRoulette
        /// Rolls a random number and color
        /// checks if the guess and the number/color are right
        /// increases attempts
        /// </summary>
        void TheRoulette()
        {
            u.balance -= bet;
            int roll = r.Next(0, 100);
            bool even = roll % 2 == 0;
            string randomColor = color[r.Next(color.Length)];
            if ((guess == "a" && randomColor == "Red") || (guess == "b" && randomColor == "Black") || (guess == "c" && even == true)
               || (guess == "d" && even == false) || (guess == "e" && roll == number) || (guess == "f" && roll < 51) || (guess == "g" && roll > 50))
            {
                Console.WriteLine("\nRound results: {0}, {1}", randomColor, roll);
                Console.WriteLine("\nYou won! Your rewards:" + bet * 2);
                u.balance += bet * 2;
                u.attempts += 1;
            }
            else
            {
                Console.WriteLine("\nRound results: {0}, {1}", randomColor, roll);
                Console.WriteLine("\nYou lost! Your loss:" + bet);
                u.attempts += 1;
            }
        }
        /// <summary>
        /// Menu Method
        /// User chooses his bet or exits the program
        /// Checks the answer and connects to other methods
        /// </summary>
        public void TheMainMenu()
        {
            u.ShowBalance();
            Console.WriteLine("\nChoose your bet : a.Red b.Black c.Even d.Odd e.My number f.First Half g.Second Half h.Exit");

            guess = Console.ReadLine();
            switch (guess.ToLower())
            {
                case "a":
                    Bet();
                    break;
                case "b":
                    Bet();
                    break;
                case "c":
                    Bet();
                    break;
                case "d":
                    Bet();
                    break;
                case "e":
                    Console.WriteLine("\nChoose your number between 0 and 100 : ");
                    number = Convert.ToInt32(Console.ReadLine());
                    while ((number > 100) || (number < 0))
                    {
                        Console.WriteLine("\nIncorrect number! Press any key to try again");
                        Console.ReadKey();

                        Console.WriteLine("\nChoose your number between 0 and 100 : ");
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    Bet();
                    break;
                case "f":
                    Bet();
                    break;
                case "g":
                    Bet();
                    break;
                case "h":
                    Console.WriteLine("\nClosing the roulette. Have a good day!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nIncorrect letter! Press any key to try again.");
                    Console.ReadKey();
                    TheMainMenu();
                    break;

            }
            Continue();
        }
        /// <summary>
        /// Asks if user wants to try again
        /// Exits the program
        /// </summary>
        void Continue()
        {
            Console.WriteLine("\nTry again? Y/N : ");
            string answer = Console.ReadLine();
            switch (answer.ToUpper())
            {
                case "Y":
                    TheMainMenu();
                    break;
                case "N":
                    Console.WriteLine("\nClosing the roulette. Have a good day!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nIncorrect letter! Press any key to try again.");
                    Console.ReadKey();
                    Continue();
                    break;
            }
        }
        /// <summary>
        /// Checks if bet is bigger than your balance
        /// Starts the roulette
        /// </summary>
        void Bet()
        {
            Console.WriteLine("\nHow much will you bet?");
            bet = Convert.ToInt32(Console.ReadLine());
            while (bet > u.balance)
            {
                Console.WriteLine("\nYou dont have enough balance! Press any key to try again.");
                Console.ReadKey();

                Console.WriteLine("\nHow much will you bet?");
                bet = Convert.ToInt32(Console.ReadLine());
            }
            TheRoulette();
        }
    }
}
