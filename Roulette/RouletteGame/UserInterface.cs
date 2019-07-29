using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteGame.BusinessEntities;
using RouletteGame.BusinessServices;

namespace RouletteGame
{
    public class UserInterface
    {
        public void ShowBalance(UserEntity u)
        {
            Console.WriteLine($"\nYour balance is : {u.Balance}   Attempts : {u.Attempts}");
        }

        public void RoundResults(RouletteEntity r)
        {
            Console.WriteLine($"\nRound results: {r.RandomColor}, {r.Roll}");
        }

        public void Win(RouletteEntity r)
        {
            Console.WriteLine($"\nYou won! Your rewards: { r.Bet * r.Multiplier}");
        }

        public void Loss(RouletteEntity r)
        {
            Console.WriteLine($"\nYou lost! Your loss: {r.Bet}");
        }

        public void Choice(RouletteEntity r)
        {
            Console.WriteLine("\nChoose your bet : a.Red b.Black c.White d.Green e.Even f.Odd g.First Half h.Second Half i.Exit");
            r.Guess = Console.ReadLine();
        }

        public void Exit()
        {
            Console.WriteLine("\nClosing the roulette. Have a good day!");
            Console.ReadKey();
        }

        public void IncorrectInput()
        {
            Console.WriteLine("\nIncorrect input! press any key to try again.");
            Console.ReadKey();
        }

        public void TryAgain(RouletteEntity r)
        {
            Console.WriteLine("\nTry again? Y/N : ");
            r.Guess = Console.ReadLine();
        }

        public void YourBet()
        {
            Console.WriteLine("\nHow much will you bet?");
        }

        public void NotEnoughBalance()
        {
            Console.WriteLine("\nYou dont have enough balance! Press any key to try again.");
            Console.ReadKey();
        }

        public void ShowUserCount(RouletteEntity r)
        {
            Console.WriteLine($"\nUsers playing right now: {r.PlayerCount}");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
