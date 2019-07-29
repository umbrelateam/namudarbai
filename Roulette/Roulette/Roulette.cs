using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Roulette
    {
        User u = new User(5000);
        string[] color = { "Red", "Black"};
        Random r = new Random();
        int bet = new int();
        string guess;

        /// <summary>
        /// TheRoulette
        /// Rolls a random number and color
        /// checks if the guess and the number/color are right
        /// increases attempts
        /// </summary>
        void TheRoulette()
        {
            u.Balance -= bet;
            int roll = r.Next(0, 100);
            bool even = roll % 2 == 0;
            string randomColor = color[r.Next(color.Length)];
            if ((guess == "a" && randomColor == "Red") || (guess == "b" && randomColor == "Black") || (guess == "c" && even == true)
               || (guess == "d" && even == false) || (guess == "e" && roll < 51) || (guess == "f" && roll > 50))
            {
                Console.WriteLine($"\nRound results: {randomColor}, {roll}");
                Console.WriteLine($"\nYou won! Your rewards: { bet * 2}");
                u.Balance += bet * 2;
                u.Attempts += 1;
            }
            else
            {
                Console.WriteLine($"\nRound results: {randomColor}, {roll}");
                Console.WriteLine($"\nYou lost! Your loss: {bet}");
                u.Attempts += 1;
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
            Console.WriteLine("\nChoose your bet : a.Red b.Black c.Even d.Odd e.First Half f.Second Half g.Exit");

            guess = Console.ReadLine();
            switch (guess.ToLower())
            {
                case "a":
                case "b":
                case "c":
                case "d":
                case "e":
                case "f":
                    Bet();
                    break;
                case "g":
                    Console.WriteLine("\nClosing the roulette. Have a good day!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nIncorrect input! press any key to try again.");
                    Console.ReadKey();
                    TheMainMenu();
                    break;
            }
            Continue();
        }
        /// <summary>
        /// Continue
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
                    Console.WriteLine("\nIncorrect input! press any key to try again.");
                    Console.ReadKey();
                    Continue();
                    break;
            }
        }
        /// <summary>
        /// Bet
        /// Checks if bet is bigger than your balance
        /// Starts the roulette
        /// </summary>
        void Bet()
        {
            Console.WriteLine("\nHow much will you bet?");
            try
            {
                bet = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nIncorrect input! press any key to try again.");
                Console.ReadKey();
                Bet();
                return;
            }
            while (bet > u.Balance)
            {
                Console.WriteLine("\nYou dont have enough balance! Press any key to try again.");
                Console.ReadKey();
                Bet();
                return;
            }
            TheRoulette();
        }
    }
}
