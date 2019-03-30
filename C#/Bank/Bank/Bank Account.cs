using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    /// <summary>
    /// Класс Bank Account
    /// Хранит все методы для работы программы
    /// </summary>
    public class Bank_Account
    {
        public int AccountNumber;
        public String Currency;
        public double Deposit;
        public double Balance;
        public double Withdrawal;
        public String answer;

        /// <summary>
        /// Метод Continue
        /// Дает пользователю выбор на продолжение или закрытие программмы
        /// </summary>
        public void Continue()
        {
            Console.WriteLine("\nContinue? Y/N : ");
            answer = Console.ReadLine();
            if (answer == "Y")
            {
                TheBankProgram();
            }
            else if (answer == "N")
            {
                Console.WriteLine("\nClosing the program. Have a good day!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nIncorrect answer! Please try again.");
                Continue();
            }
        }
        /// <summary>
        /// Метод TheBankProgram
        /// Соединяет все методы
        /// </summary>
        public void TheBankProgram()
        {
            Console.WriteLine("\nYour balance is: " + ShowMoney() + Currency);
            Console.WriteLine("\nPress d to Deposit, w to Withdraw or e to exit");
            answer = Console.ReadLine();

            if (answer == "d")
            {
                ToDeposit();
            }

            else if (answer == "w")
            {
                ToWithdraw();
            }
            else if (answer == "e")
            {
                Console.WriteLine("\nClosing the program. Have a good day!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nIncorrect answer! Please try again.");
                TheBankProgram();
            }
        }     

        /// <summary>
        /// Метод ShowBalance
        /// Показывает текущий баланс
        /// </summary>
        /// <returns>Баланс</returns>
        public double ShowMoney()
        {
            return Balance;
        }

        /// <summary>
        /// Метод ToDeposit
        /// проверка на лимит пополнение в день
        /// проверка на лимит пополнение за транзакцию
        /// пополнение баланса
        /// </summary>
        public void ToDeposit()
        {
            if (Balance == 1500000)
            {
                Console.WriteLine("\n500000 euro is a deposit limit per day!");
                TheBankProgram();
            }
            Console.WriteLine("\nEnter the amount to deposit: ");
            Deposit = Convert.ToDouble(Console.ReadLine());
            if (Deposit > 50000)
            {
                Console.WriteLine("\n50000 euro is a deposit limit per transaction!");
                ToDeposit();
            }
            Balance = Balance + Deposit;
            if (Balance > 1500000)
            {
                Console.WriteLine("\n500000 euro is a deposit limit per day!");
                Balance = Balance - Deposit;
                ToDeposit();
            }
            Console.WriteLine("\nYour new balance is: {0}", Balance);
            Continue();
        }

        /// <summary>
        /// Метод ToWithdraw
        /// проверка на лимит вывода в день
        /// проверка на лимит вывода за транзакцию
        /// вывод средств с банковского счета
        /// </summary>
        public void ToWithdraw()
        {
            if (Balance == 900000)
            {
                Console.WriteLine("\n100000 euro is a withdrawal limit per day!");
                TheBankProgram();
            }
            Console.WriteLine("\nEnter the amount to withdrawal: ");
            Withdrawal = Convert.ToDouble(Console.ReadLine());
            if (Withdrawal > 50000)
            {
                Console.WriteLine("\n50000 euro is a withdrawal limit per transaction!");
                ToWithdraw();
            }
            if (Withdrawal > Balance)
            {
                Console.WriteLine("\nNot enough balance! Please try again.");
                ToWithdraw();
            }
            Balance = Balance - Withdrawal;
            if (Balance < 900000)
            {
                Console.WriteLine("\n100000 euro is a withdrawal limit per day!");
                Balance = Balance + Withdrawal;
                ToWithdraw();
            }
            Console.WriteLine("\nYour new balance is: {0}", Balance);
            Continue();
        }
    }
}
