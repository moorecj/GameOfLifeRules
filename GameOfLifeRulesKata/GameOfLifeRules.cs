﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeRulesKata
{
    [Flags]
    public enum State : int { Dead = 0, Alive = 1};
    
    public class GameOfLifeRules
    {
        static public State ApplyRules( int numberOfNeighbors, State cellState )
        {

            if (numberOfNeighbors < 2)
                cellState = State.Dead;

            if( numberOfNeighbors > 3)
                cellState = State.Dead;

            if (numberOfNeighbors == 3)
                cellState = State.Alive;

            return (cellState);
               
        }
    }
}
