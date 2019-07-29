﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class User
    {
        private int balance;
        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        private int attempts;
        public int Attempts
        {
            get { return this.attempts; }
            set { this.attempts = value; }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Your balance is : {balance}   Attempts : {attempts}");
        }
        public User(int b)
        {
            balance = b;
        }
    }
}
