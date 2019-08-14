using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRoulette.Models
{
    public class RouletteServices
    {
        void TheRoulette(Roulette R, User U)
        {
            R.RandomColor = R.Color[R.r.Next(R.Color.Length)];
            R.Roll = R.r.Next(0, 100);
            R.Even = R.Roll % 2 == 0;
            U.Balance -= R.Bet;
            if ((R.Guess == "a" && R.RandomColor == "Red") || (R.Guess == "b" && R.RandomColor == "Black") || (R.Guess == "c" && R.RandomColor == "White") || (R.Guess == "d" && R.RandomColor == "Green") || (R.Guess == "e" && R.Even == true)
               || (R.Guess == "f" && R.Even == false) || (R.Guess == "g" && R.Roll < 51) || (R.Guess == "h" && R.Roll > 50))
            {
                U.Balance += R.Bet * R.Multiplier;
                U.Attempts += 1;
            }
            else
            {
                U.Attempts += 1;
            }
        }

        void BetCheck(Roulette R, User U)
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    R.Bet = Convert.ToInt32(Console.ReadLine());
                    while (R.Bet > U.Balance)
                    {
                        R.Bet = Convert.ToInt32(Console.ReadLine());
                    }
                    tryAgain = false;
                }
                catch
                {

                }
            }
            TheRoulette(R, U);
        }

        public void MultiplierCheck(Roulette R)
        {
            R.PlayerCount = R.r.Next(0, 100);

            if (R.PlayerCount <= 25)
            {
                R.Multiplier = 5;
            }
            else if (R.PlayerCount > 25 && R.PlayerCount <= 50)
            {
                R.Multiplier = 4;
            }
            else if (R.PlayerCount > 50 && R.PlayerCount <= 75)
            {
                R.Multiplier = 3;
            }
            else if (R.PlayerCount > 75 && R.PlayerCount <= 100)
            {
                R.Multiplier = 2;
            }
        }
    }
}