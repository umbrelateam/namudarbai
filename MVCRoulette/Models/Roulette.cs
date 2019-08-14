using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRoulette.Models
{
    public class Roulette
    {
        public string[] Color = { "Red", "Black", "White", "Green" };
        public string RandomColor { get; set; }
        public int Roll { get; set; }
        public bool Even { get; set; }
        public int PlayerCount { get; set; }
        public int Multiplier { get; set; }

        public Random r = new Random();
        public int Bet { get; set; }
        public string Guess { get; set; }
    }
}