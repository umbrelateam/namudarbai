using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRoulette.Models
{
    public class User
    {
        public int Balance { get; set; }

        public int Attempts { get; set; }

        public User(int b)
        {
            Balance = b;
        }
    }
}