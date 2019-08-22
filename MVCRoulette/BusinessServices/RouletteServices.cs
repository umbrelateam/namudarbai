using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRoulette.Models
{
    public class RouletteServices
    {
        //public void TheRoulette(Roulette R, Users U)
        //{
        //    R.RandomColor = R.Color[R.r.Next(R.Color.Length)];
        //    R.Roll = R.r.Next(0, 100);
        //    R.Even = R.Roll % 2 == 0;
        //    U.Balance -= R.Bet;
        //    if ((R.Guess == "Red" && R.RandomColor == "Red") || (R.Guess == "Black" && R.RandomColor == "Black") || (R.Guess == "White" && R.RandomColor == "White") || (R.Guess == "Green" && R.RandomColor == "Green") || (R.Guess == "Even" && R.Even == true)
        //       || (R.Guess == "Odd" && R.Even == false) || (R.Guess == "FirstHalf" && R.Roll < 51) || (R.Guess == "SecondHalf" && R.Roll > 50))
        //    {
        //        U.Balance += R.Bet * R.Multiplier;
        //        U.Attempts += 1;
        //    }
        //    else
        //    {
        //        U.Attempts += 1;
        //    }
        //}

        public void BetCheck(Roulette R, Users U)
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