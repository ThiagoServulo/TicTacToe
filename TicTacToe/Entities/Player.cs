﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe.Entities
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

        public void AddVictory()
        {
            ++Victories;
        }

        public void AddDraw()
        {
            ++Draws;
        }
    }
}