using System;
using System.Collections.Generic;

namespace PlutoRover
{
    public class ObstacleCoOrdinates
    {
        public int XCoOrdinate { get; set;}
        public int YCoOrdinate { get; set; }

        public ObstacleCoOrdinates() { }

        public ObstacleCoOrdinates(int x, int y)
        {
            XCoOrdinate = x;
            YCoOrdinate = y;
        }        
    }
}
