using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteGame.BusinessEntities;

namespace RouletteGame.BusinessServices
{
    public class RouletteServices
    {
        void TheRoulette(RouletteEntity RE, UserEntity UE, UserInterface UI)
        {
            UI.ShowUserCount(RE);
            RE.RandomColor = RE.color[RE.r.Next(RE.color.Length)];
            RE.Roll = RE.r.Next(0, 100);
            RE.Even = RE.Roll % 2 == 0;
            UE.Balance -= RE.Bet;
            if ((RE.Guess == "a" && RE.RandomColor == "Red") || (RE.Guess == "b" && RE.RandomColor == "Black") || (RE.Guess == "c" && RE.RandomColor == "White") || (RE.Guess == "d" && RE.RandomColor == "Green") || (RE.Guess == "e" && RE.Even == true)
               || (RE.Guess == "f" && RE.Even == false) || (RE.Guess == "g" && RE.Roll < 51) || (RE.Guess == "h" && RE.Roll > 50))
            {
                UI.RoundResults(RE);
                UI.Win(RE);
                UE.Balance += RE.Bet * RE.Multiplier;
                UE.Attempts += 1;
            }
            else
            {
                UI.RoundResults(RE);
                UI.Loss(RE);
                UE.Attempts += 1;
            }
        }

        public void TheMainMenu( RouletteEntity RE, UserEntity UE, UserInterface UI)
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                UI.ShowBalance(UE);
                UI.Choice(RE);
                switch (RE.Guess.ToLower())
                {
                    case "a":
                    case "b":
                    case "c":
                    case "d":
                    case "e":
                    case "f":
                    case "g":
                    case "h":
                        MultiplierCheck(RE);
                        BetCheck(RE, UE, UI);
                        tryAgain = false;
                        break;
                    case "i":
                        UI.Exit();
                        Environment.Exit(0);
                        break;
                    default:
                        UI.IncorrectInput();
                        break;
                }
            }
            Continue(RE, UE, UI);
        }

        void Continue(RouletteEntity RE, UserEntity UE, UserInterface UI)
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                UI.TryAgain(RE);
                switch (RE.Guess.ToUpper())
                {
                    case "Y":
                        TheMainMenu(RE, UE, UI);
                        tryAgain = false;
                        break;
                    case "N":
                        UI.Exit();
                        Environment.Exit(0);
                        break;
                    default:
                        UI.IncorrectInput();
                        break;
                }
            }
        }

        void BetCheck(RouletteEntity RE, UserEntity UE, UserInterface UI)
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    UI.YourBet();
                    RE.Bet = Convert.ToInt32(Console.ReadLine());
                    while (RE.Bet > UE.Balance)
                    {
                        UI.NotEnoughBalance();
                        UI.YourBet();
                        RE.Bet = Convert.ToInt32(Console.ReadLine());
                    }
                    tryAgain = false;
                }
                catch
                {
                    UI.IncorrectInput();
                }
            }
            TheRoulette(RE, UE, UI);
        }

        public void MultiplierCheck(RouletteEntity RE)
        {
            RE.PlayerCount = RE.r.Next(0, 100);

            if (RE.PlayerCount <= 25)
            {
                RE.Multiplier = 5;
            }
            else if (RE.PlayerCount > 25 && RE.PlayerCount <= 50)
            {
                RE.Multiplier = 4;
            }
            else if (RE.PlayerCount > 50 && RE.PlayerCount <= 75)
            {
                RE.Multiplier = 3;
            }
            else if (RE.PlayerCount > 75 && RE.PlayerCount <= 100)
            {
                RE.Multiplier = 2;
            }
        }
    }
}
