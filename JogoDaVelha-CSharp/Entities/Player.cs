using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha_CSharp.Entities
{
    class Player
    {
        public int Victories { get; set; }
        public int Draws { get; set; }
        public char Symbol { get; set; }

        public Player(int victories, int draws, char symbol)
        {
            Victories = victories;
            Draws = draws;
            Symbol = symbol;
        }
    }
}
