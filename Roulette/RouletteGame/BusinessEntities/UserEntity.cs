using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame.BusinessEntities
{
    public class UserEntity
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

        public UserEntity(int b)
        {
            balance = b;
        }
    }
}
