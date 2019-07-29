using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame.BusinessEntities
{
    public class RouletteEntity
    {

        public string[] color = { "Red", "Black", "White", "Green" };

        private string randomColor;

        public string RandomColor
        {
            get { return this.randomColor; }
            set { this.randomColor = value; }
        }

        private int roll = new int();

        public int Roll
        {
            get { return this.roll; }
            set { this.roll = value; }
        }


        private bool even = new bool();

        public bool Even
        {
            get { return this.even; }
            set { this.even = value; }
        }

        private int playerCount = new int();

        public int PlayerCount
        {
            get { return this.playerCount; }
            set { this.playerCount = value; }
        }

        private int multiplier = new int();

        public int Multiplier
        {
            get { return this.multiplier; }
            set { this.multiplier = value; }
        }

        public Random r = new Random();
        private int bet = new int();

        public int Bet
        {
            get { return this.bet; }
            set { this.bet = value; }
        }

        private string guess;

        public string Guess
        {
            get { return this.guess; }
            set { this.guess = value; }
        }
    }
}
