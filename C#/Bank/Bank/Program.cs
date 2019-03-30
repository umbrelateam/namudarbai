using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    /// <summary>
    /// Класс Program
    /// основной класс программы
    /// Создание Банковского счета
    /// Его валюты и баланса
    /// Запуск Метода TheBankProgram (Класса Bank Account)
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод Main()
        /// входная точка работы программы
        /// </summary>
        /// <param name="args">Аргумент метода Main()</param>
        static void Main(string[] args)
        {
            Bank_Account BankAccount1 = new Bank_Account();
            BankAccount1.AccountNumber = 1;
            BankAccount1.Currency = " Euro";
            BankAccount1.Balance = 1000000;
            BankAccount1.TheBankProgram();
            Console.ReadKey();
        }
    }
}
