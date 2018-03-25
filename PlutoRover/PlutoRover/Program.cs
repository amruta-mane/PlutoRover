using System;
using System.Collections.Generic;
/// <summary>
/// Main Class for Pluto Rover
/// </summary>
namespace PlutoRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string move = "LRLLFB";

            List<ObstacleCoOrdinates> obstacles = new List<ObstacleCoOrdinates> { new ObstacleCoOrdinates(1, 1) };

            Rover rover = new Rover(new Grid (10, 10, obstacles));

            ObstacleCoOrdinates obstacleCo;
            RoverLocation location = rover.MoveRover(move, out obstacleCo);
            
            if (obstacleCo.XCoOrdinate != 0 && obstacleCo.YCoOrdinate != 0)
            {
                Console.WriteLine($"Obstacle at '{obstacleCo.XCoOrdinate}, {obstacleCo.YCoOrdinate}'. Rover's current location : {location.CurrentX},{location.CurrentY},{location.CurrentDirection}");
            }
            else
            {
                Console.WriteLine($"Rover's current location : {location.CurrentX},{location.CurrentY},{location.CurrentDirection}");
            }
        }
    }

    public enum Direction
    {
        N, E, S, W
    };
}
